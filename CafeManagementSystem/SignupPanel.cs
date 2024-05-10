using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using System.Data;

namespace CafeManagementSystem
{
    internal class SignupPanel
    {
        private const string connectionString = "Data Source=CODING-0\\SQLEXPRESS;Initial Catalog=database_project;Integrated Security=True";


        public Panel signupPanel;
        private Button signupButton;
        private Label roleLabel;
        private ComboBox selectRoleDropdown;
        private TextBox passwordTextarea;
        private Label passwordLabel;
        private TextBox emailTextarea;
        private Label emailLabel;
        private Label messageLabel;
        private TextBox usernameTextarea;
        private Label usernameLabel;
        public SignupPanel()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestingForm));
            signupPanel = new Panel();
            usernameTextarea = new TextBox();
            usernameLabel = new Label();
            signupButton = new Button();
            roleLabel = new Label();
            selectRoleDropdown = new ComboBox();
            passwordTextarea = new TextBox();
            passwordLabel = new Label();
            emailTextarea = new TextBox();
            emailLabel = new Label();
            messageLabel = new Label();

            // 
            // usernameTextarea
            // 
            usernameTextarea.Location = new Point(62, 177);
            usernameTextarea.Name = "usernameTextarea";
            usernameTextarea.PlaceholderText = "Enter username";
            usernameTextarea.Size = new Size(223, 23);
            usernameTextarea.TabIndex = 20;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(62, 156);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(72, 18);
            usernameLabel.TabIndex = 19;
            usernameLabel.Text = "Username";
            // 
            // signupButton
            // 
            signupButton.BackColor = SystemColors.ControlDark;
            signupButton.FlatStyle = FlatStyle.Flat;
            signupButton.Font = new System.Drawing.Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupButton.Location = new Point(88, 396);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(157, 32);
            signupButton.TabIndex = 18;
            signupButton.Text = "Signup";
            signupButton.UseVisualStyleBackColor = false;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new System.Drawing.Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roleLabel.Location = new Point(62, 305);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(40, 18);
            roleLabel.TabIndex = 17;
            roleLabel.Text = "Role";
            // 
            // selectRoleDropdown
            // 
            selectRoleDropdown.FormattingEnabled = true;
            selectRoleDropdown.Items.AddRange(new object[] { "User", "Admin", "Staff" });
            selectRoleDropdown.Location = new Point(62, 326);
            selectRoleDropdown.Name = "selectRoleDropdown";
            selectRoleDropdown.Size = new Size(223, 23);
            selectRoleDropdown.TabIndex = 16;
            // 
            // passwordTextarea
            // 
            passwordTextarea.Location = new Point(62, 251);
            passwordTextarea.Name = "passwordTextarea";
            passwordTextarea.PlaceholderText = "Enter password";
            passwordTextarea.Size = new Size(223, 23);
            passwordTextarea.TabIndex = 14;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(62, 230);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(72, 18);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Password";
            // 
            // emailTextarea
            // 
            emailTextarea.Location = new Point(62, 98);
            emailTextarea.Name = "emailTextarea";
            emailTextarea.PlaceholderText = "Enter your email";
            emailTextarea.Size = new Size(223, 23);
            emailTextarea.TabIndex = 12;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(62, 77);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(48, 18);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email";

            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new System.Drawing.Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(104, 25);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(128, 18);
            messageLabel.TabIndex = 10;
            messageLabel.Text = "Ready to Signup";
            messageLabel.TextAlign = ContentAlignment.TopCenter;
           
            // 
            // signupPanel
            // 
            signupPanel.Controls.Add(usernameTextarea);
            signupPanel.Controls.Add(usernameLabel);
            signupPanel.Controls.Add(signupButton);
            signupPanel.Controls.Add(roleLabel);
            signupPanel.Controls.Add(selectRoleDropdown);
            signupPanel.Controls.Add(passwordTextarea);
            signupPanel.Controls.Add(passwordLabel);
            signupPanel.Controls.Add(emailTextarea);
            signupPanel.Controls.Add(emailLabel);
            signupPanel.Controls.Add(messageLabel);
            signupPanel.Location = new Point(204, 23);
            signupPanel.Name = "signupPanel";
            signupPanel.Size = new Size(362, 486);
            signupPanel.TabIndex = 11;
            signupButton.Click += signupButton_Click;
            signupPanel.ResumeLayout(false);
            signupPanel.PerformLayout();

        }
        public void signupButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextarea.Text;
            string email = emailTextarea.Text;
            string password = passwordTextarea.Text;
            string role = selectRoleDropdown.Text;
            if (string.IsNullOrWhiteSpace(username))
            {
                messageLabel.Text = "Username cannot be empty.";
                messageLabel.ForeColor = Color.Red;
                return; // Exit the method
            }

            // Check if email is empty or not in a valid format
            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
            {
                messageLabel.Text = "Invalid email address.";
                messageLabel.ForeColor = Color.Red;
                return; // Exit the method
            }

            // Check if password is empty
            if (string.IsNullOrWhiteSpace(password))
            {
                messageLabel.Text = "Password cannot be empty.";
                messageLabel.ForeColor = Color.Red;
                return; // Exit the method
            }

            // Check if role is selected
            if (string.IsNullOrWhiteSpace(role))
            {
                messageLabel.Text = "Please select a role.";
                messageLabel.ForeColor = Color.Red;
                return; // Exit the method
            }

            string insertQuery = "INSERT INTO Customer (username, email, password, role) VALUES (@Username, @Email, @Password, @Role)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                // Add parameters to the command
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Role", role);

                try
                {
                    // Open the connection
                    connection.Open();

                    // Execute the command
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer inserted successfully.");
                        signupPanel.Hide();
                        
                       
                        
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert customer.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
