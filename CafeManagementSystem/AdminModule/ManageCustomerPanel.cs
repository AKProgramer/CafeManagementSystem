using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeManagementSystem.AdminModule
{
    internal class ManageCustomerPanel
    {
        private const string connectionStringQuery = "Data Source=CODING-0\\SQLEXPRESS;Initial Catalog=database_project;Integrated Security=True";
        private string selectQuery = "Select * from Customer";
        public Panel manageCPanel;
        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.TextBox searchbar;
        private Label label5;
        private Label label7;
        private Label label13;
        private Label label9;
        private Label label11;
        private Label label10;
        private Label label8;
        private Panel scrollablePanel;
      
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button cancelBtn;

        public ManageCustomerPanel()
        {
           
            manageCPanel = new Panel();
            cancelBtn = new System.Windows.Forms.Button();
            deleteBtn = new System.Windows.Forms.Button();
            scrollablePanel = new Panel();
            filter = new System.Windows.Forms.ComboBox();
            label8 = new Label();
            label13 = new Label();
            label9 = new Label();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            label5 = new Label();
            searchbar = new System.Windows.Forms.TextBox();
            manageCPanel.SuspendLayout();
            scrollablePanel.SuspendLayout();
            // 
            // manageCPanel
            // 
            manageCPanel.AutoScroll = true;
            manageCPanel.BackColor = Color.FromArgb(224, 224, 224);
            manageCPanel.BorderStyle = BorderStyle.Fixed3D;
            manageCPanel.Controls.Add(cancelBtn);
            manageCPanel.Controls.Add(deleteBtn);
            manageCPanel.Controls.Add(scrollablePanel);
            manageCPanel.Controls.Add(filter);
            manageCPanel.Controls.Add(label8);
            manageCPanel.Controls.Add(label13);
            manageCPanel.Controls.Add(label9);
            manageCPanel.Controls.Add(label11);
            manageCPanel.Controls.Add(label10);
            manageCPanel.Controls.Add(label7);
            manageCPanel.Controls.Add(label5);
            manageCPanel.Controls.Add(searchbar);
            manageCPanel.Location = new Point(119, 54);
            manageCPanel.Name = "manageCPanel";
            manageCPanel.Size = new Size(710, 498);
            manageCPanel.TabIndex = 6;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Gray;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold);
            cancelBtn.Location = new Point(385, 419);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(125, 39);
            cancelBtn.TabIndex = 27;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Green;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold);
            deleteBtn.ForeColor = Color.Black;
            deleteBtn.Location = new Point(540, 419);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(125, 39);
            deleteBtn.TabIndex = 26;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // scrollablePanel
            // 
            scrollablePanel.AutoScroll = true;
         
            scrollablePanel.Location = new Point(36, 165);
            scrollablePanel.Name = "scrollablePanel";
            scrollablePanel.Size = new Size(629, 237);
            scrollablePanel.TabIndex = 25;
            // 
            // filter
            // 
            filter.FormattingEnabled = true;
            filter.Location = new Point(577, 84);
            filter.Name = "filter";
            filter.Size = new Size(88, 23);
            filter.TabIndex = 7;

            filter.Items.Add("Username");
            filter.Items.Add("Email");
            filter.Items.Add("Role");
            filter.Items.Add("UserID");
            filter.SelectedItem = "Username";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(42, 143);
            label8.Name = "label8";
            label8.Size = new Size(62, 19);
            label8.TabIndex = 13;
            label8.Text = "Item ID";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(127, 143);
            label13.Name = "label13";
            label13.Size = new Size(80, 19);
            label13.TabIndex = 18;
            label13.Text = "Username";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(234, 143);
            label9.Name = "label9";
            label9.Size = new Size(47, 19);
            label9.TabIndex = 14;
            label9.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(440, 143);
            label11.Name = "label11";
            label11.Size = new Size(76, 19);
            label11.TabIndex = 16;
            label11.Text = "Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(577, 143);
            label10.Name = "label10";
            label10.Size = new Size(53, 19);
            label10.TabIndex = 15;
            label10.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(42, 9);
            label7.Name = "label7";
            label7.Size = new Size(217, 28);
            label7.TabIndex = 12;
            label7.Text = "Manage Customers";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(532, 87);
            label5.Name = "label5";
            label5.Size = new Size(39, 16);
            label5.TabIndex = 9;
            label5.Text = "Filter";
            // 
            // searchbar
            // 
            searchbar.Location = new Point(440, 58);
            searchbar.Name = "searchbar";
            searchbar.PlaceholderText = "Search customers";
            searchbar.Size = new Size(225, 23);
            searchbar.TabIndex = 6;
            searchbar.TextChanged += searchbar_TextChanged;



            manageCPanel.ResumeLayout(false);
            manageCPanel.PerformLayout();
            scrollablePanel.ResumeLayout(false);
            executeSelectQuery();
          
        }
        public void deleteBtn_Click(object sender, EventArgs e)
        {
            string customerIdToDelete = string.Empty;
            foreach (Control control in scrollablePanel.Controls)
            {
                if (control is Panel panel && panel.BackColor == Color.Green)
                {
                    foreach (Control innerControl in panel.Controls)
                    {
                        if (innerControl is Label label && label.Name == "itemIDLabel")
                        {
                            customerIdToDelete = label.Text;
                            break;
                        }
                    }
                    if (!string.IsNullOrEmpty(customerIdToDelete))
                    {
                        break;
                    }
                }
            }
        if (!string.IsNullOrEmpty(customerIdToDelete))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DeleteCustomer(customerIdToDelete);
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchbar_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionStringQuery);
            connection.Open();
            string selectQuery = "SELECT * FROM Customer WHERE ";

            // Construct the WHERE clause based on the selected filter and search text
            switch (filter.SelectedItem?.ToString())
            {
                case "Username":
                    selectQuery += "username LIKE @SearchText";
                    break;
                case "Email":
                    selectQuery += "email LIKE @SearchText";
                    break;
                case "Role":
                    selectQuery += "role LIKE @SearchText";
                    break;
                case "UserID":
                    selectQuery += "customer_id LIKE @SearchText";
                    break;
                default:
                    // Default to searching by username if no filter is selected
                    selectQuery += "username LIKE @SearchText";
                    break;
            }

            // Adding ORDER BY clause to prioritize results starting with the search text
            selectQuery += " ORDER BY CASE WHEN username LIKE @SearchTextStart THEN 1 ELSE 2 END";

            SqlCommand command = new SqlCommand(selectQuery, connection);
            command.Parameters.AddWithValue("@SearchText", "%" + searchbar.Text.Trim() + "%");
            command.Parameters.AddWithValue("@SearchTextStart", searchbar.Text.Trim() + "%");

            SqlDataReader reader = command.ExecuteReader();

            loadCustomerData(reader);

            connection.Close();
        }

        public void executeSelectQuery()
        {
            SqlConnection connection = new SqlConnection(connectionStringQuery);
            connection.Open();
            SqlCommand command = new SqlCommand(selectQuery, connection);
            SqlDataReader reader = command.ExecuteReader();

            loadCustomerData(reader);
        }
        public void loadCustomerData(SqlDataReader reader)
        {
            this.scrollablePanel.Controls.Clear();
                 int panelContainingCustomerInfoLocation = 12;
                 int labelLocation = 28;
            bool onClick=false;
                while (reader.Read())
                {
                    string id = reader["customer_id"].ToString();
                    string username = reader["username"].ToString();
                    string email = reader["email"].ToString();
                    string password = reader["password"].ToString();
                    string role = reader["role"].ToString();

                    Label statusLabel;
                    Label passwordLabel;
                    Label itemIDLabel;
                    Label usernameLabel;
                    Label emailLabel;
                    Panel panelContainingCustomerInfo;
                    panelContainingCustomerInfo = new Panel();
                    statusLabel = new Label();
                    passwordLabel = new Label();
                    itemIDLabel = new Label();
                    usernameLabel = new Label();
                    emailLabel = new Label();
                   
                    // 
                    // statusLabel
                    // 
                    statusLabel.AutoSize = true;
                    statusLabel.BackColor = Color.White;
                    statusLabel.Font = new System.Drawing.Font("Calibri", 14.25F, FontStyle.Regular);
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Location = new Point(537, labelLocation);
                    statusLabel.Name = "statusLabel";
                    statusLabel.Size = new Size(51, 19);
                    statusLabel.TabIndex = 21;
                    statusLabel.Text = role;
                    // 
                    // passwordLabel
                    // 
                    passwordLabel.AutoSize = true;
                    passwordLabel.Font = new System.Drawing.Font("Calibri", 14.25F, FontStyle.Regular);
                    passwordLabel.ForeColor = Color.Black;
                    passwordLabel.Location = new Point(398, labelLocation);
                    passwordLabel.Name = "passwordLabel";
                    passwordLabel.Size = new Size(51, 19);
                    passwordLabel.TabIndex = 22;
                    passwordLabel.Text = password;
                    // 
                    // itemIDLabel
                    // 
                    itemIDLabel.AutoSize = true;
                    itemIDLabel.BackColor = Color.DimGray;
                    itemIDLabel.Font = new System.Drawing.Font("Calibri", 14.25F, FontStyle.Regular);
                    itemIDLabel.ForeColor = Color.Black;
                    itemIDLabel.Location = new Point(12, labelLocation);
                    itemIDLabel.Name = "itemIDLabel";
                    itemIDLabel.Size = new Size(18, 19);
                    itemIDLabel.TabIndex = 19;
                    itemIDLabel.Text = id;
                    // 
                    // usernameLabel
                    // 
                    usernameLabel.AutoSize = true;
                    usernameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, FontStyle.Regular);
                    usernameLabel.ForeColor = Color.Black;
                    usernameLabel.Location = new Point(85, labelLocation);
                    usernameLabel.Name = "usernameLabel";
                    usernameLabel.Size = new Size(51, 19);
                    usernameLabel.TabIndex = 20;
                    usernameLabel.Text = username;
                    // 
                    // emailLabel
                    // 
                    emailLabel.AutoSize = true;
                    emailLabel.Font = new System.Drawing.Font("Calibri", 14.25F, FontStyle.Regular);
                    emailLabel.ForeColor = Color.Black;
                    emailLabel.Location = new Point(188, labelLocation);
                    emailLabel.Name = "emailLabel";
                    emailLabel.Size = new Size(51, 19);
                    emailLabel.TabIndex = 19;
                    emailLabel.Text = email;
                    // 
                    // panelContainingCustomerInfo
                    // 
                    panelContainingCustomerInfo.BackColor = Color.White;
                    panelContainingCustomerInfo.Controls.Add(statusLabel);
                    panelContainingCustomerInfo.Controls.Add(passwordLabel);
                    panelContainingCustomerInfo.Controls.Add(itemIDLabel);
                    panelContainingCustomerInfo.Controls.Add(usernameLabel);
                    panelContainingCustomerInfo.Controls.Add(emailLabel);
                    panelContainingCustomerInfo.Location = new Point(6, panelContainingCustomerInfoLocation);
                    panelContainingCustomerInfo.Name = "panelContainingCustomerInfo";
                    panelContainingCustomerInfo.Click+=(sender,e)=>
                    {
                        if(onClick)
                        {
                            onClick = false;
                            panelContainingCustomerInfo.BackColor = Color.White;
                        }
                        else
                        {
                            onClick = true;
                            panelContainingCustomerInfo.BackColor = Color.Green;
                        }
                        
                    };
                    panelContainingCustomerInfo.Size = new Size(603, 65);
                    panelContainingCustomerInfo.TabIndex = 23;
                    panelContainingCustomerInfo.ResumeLayout(false);
                    panelContainingCustomerInfo.PerformLayout();
                    panelContainingCustomerInfo.SuspendLayout();
                    scrollablePanel.Controls.Add(panelContainingCustomerInfo);

                    panelContainingCustomerInfoLocation +=70;


                }


            
        }
        private void DeleteCustomer(string customerId)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringQuery))
            {
                connection.Open();
                string deleteQuery1 = "Delete from OrderTable where CustomerID = @CustomerId";
                SqlCommand command1 = new SqlCommand(deleteQuery1, connection);
                command1.Parameters.AddWithValue("@CustomerId", customerId);
                command1.ExecuteNonQuery();
                string deleteQuery = "DELETE FROM Customer WHERE customer_id = @CustomerId";
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@CustomerId", customerId);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    // Customer deleted successfully
                    MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally, you may refresh the data in the UI after deletion
                    // Call a method to reload the customer data or update the UI accordingly
                    executeSelectQuery(); // Assuming executeSelectQuery reloads the customer data
                }
                else
                {
                    // Customer deletion failed
                    MessageBox.Show("Failed to delete customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            string customerIdToDelete = string.Empty;
            foreach (Control control in scrollablePanel.Controls)
            {
                if (control is Panel panel && panel.BackColor == Color.Green)
                {
                    panel.BackColor = Color.White;
                    if (!string.IsNullOrEmpty(customerIdToDelete))
                    {
                        break;
                    }
                }

            }

        }



    }

}