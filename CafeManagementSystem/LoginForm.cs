using CafeManagementSystem.AdminModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class LoginForm : Form
    {
        private const string connectionString = "Data Source=CODING-0\\SQLEXPRESS;Initial Catalog=database_project;Integrated Security=True";
        SignupPanel signup;
        Color color;
        public LoginForm()
        {
            InitializeComponent();
            color = Color.CadetBlue;
            signup=new SignupPanel();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginMouseEnter(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.Aqua;
        }

        private void loginMouseLeave(object sender, EventArgs e)
        {
            loginButton.BackColor = color;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextarea.Text;
            string password = passwordTextarea.Text;
            if (string.IsNullOrWhiteSpace(username))
            {
                ShowErrorMessage("Username cannot be empty.");
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                ShowErrorMessage("Password cannot be empty.");
                return; 
            }
            // SQL query to check login credentials and retrieve role
            string loginQuery = "SELECT role FROM Customer WHERE username = @Username AND password = @Password";
            string selectCurrentUser = "select * from Customer where username = @Username AND password = @Password";
            // Create SqlConnection and SqlCommand objects
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(loginQuery, connection))
            {
                // Add parameters to the command
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    // Open the connection
                    connection.Open();

                    // Execute the command
                    object roleObj = command.ExecuteScalar();

                    // Check if login is successful
                    if (roleObj != null)
                    {
                        string? role = roleObj.ToString();
                        MessageBox.Show("Login successful. Your role is: " + role);

                        // Redirect based on role
                        switch (role)
                        {
                            case "admin":
                                // Open admin form
                                AdminForm adminForm = new AdminForm();
                                this.Hide();
                                adminForm.Show();
                                break;
                            case "User":
                                // Open user form
                                Menu menu2 = new Menu();
                                menu2.Show();
                                this.Hide();
                                break;
                            case "staff":
                                Menu menu3 = new Menu();
                                menu3.Show();
                                this.Hide();
                                break;
                            default:
                                MessageBox.Show("Invalid role.");
                                break;
                        }
                        /* SqlConnection connection1 = new SqlConnection(connectionString);*/
                        using (SqlCommand command1 = new SqlCommand(selectCurrentUser, connection))
                        {
                            // Add parameters to the command
                            command1.Parameters.AddWithValue("@Username", username);
                            command1.Parameters.AddWithValue("@Password", password);

                            // Execute the command
                            SqlDataReader reader = command1.ExecuteReader();
                            if (reader.Read())
                            {
                                SessonManagement.User user = new SessonManagement.User();
                                user.Id = reader.GetInt32(0);
                                user.name = reader.GetString(1);
                                user.email = reader.GetString(2);
                                user.password = reader.GetString(3);
                                user.role = reader.GetString(4);
                                SessonManagement.Session.SetCurrentUser(user);
                            }

                            reader.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void ShowErrorMessage(string message)
        {
            // Change messageLabel text and color
            messageLabel.Text = message;
            messageLabel.ForeColor = Color.Red; // Change color to red
        }


        private void signupButton_Click(object sender, EventArgs e)
        {
            signup.signupPanel.Show();
            Controls.Add(signup.signupPanel);
            signup.signupPanel.BringToFront();



        }
    }
}
