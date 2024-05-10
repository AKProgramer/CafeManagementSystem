using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace CafeManagementSystem.AdminModule
{
    internal class ManageOrdersPanel
    {
        private const string connectionStringQuery = "Data Source=CODING-0\\SQLEXPRESS;Initial Catalog=database_project;Integrated Security=True";
        private string selectQuery = "SELECT i.ItemID, c.username,i.Price, i.ImageURL, i.Name FROM OrderTable o INNER JOIN Customer c ON o.CustomerID = c.customer_id INNER JOIN Item i ON o.ItemID = i.ItemID;";
        public Panel panel;
       
        private ProgressBar orderProgressBar;
        private Label progressLabel;
        private ComboBox selectFilterComboBox;
        private TextBox searchBarLabel;
        private Label filterLabel;
        private Label manageOrdersLabel;
        private Label itemCustomerNameLabel;
        private Label itemNameLabel;
        private Label itemPicBoxLabel;
        private Label itemPriceLabel;
        private Label itemStatusLabel;
        private Label itemIDLabel;
        private Panel scrollablePanel;


       


        private Button deleteBtn;
        private Button cancleBtn;
        public ManageOrdersPanel()
        {
           
            panel = new Panel();
            cancleBtn = new Button();
            deleteBtn = new Button();
            scrollablePanel = new Panel();
           
            
           
            selectFilterComboBox = new ComboBox();
            itemIDLabel = new Label();
            itemCustomerNameLabel = new Label();
            itemNameLabel = new Label();
            itemPicBoxLabel = new Label();
            itemPriceLabel = new Label();
            itemStatusLabel = new Label();
            manageOrdersLabel = new Label();
            filterLabel = new Label();
            progressLabel = new Label();
            searchBarLabel = new TextBox();
            orderProgressBar = new ProgressBar();
           
            panel.SuspendLayout();
            scrollablePanel.SuspendLayout();
            // 
            // panel
            // 
            panel.AutoScroll = true;
            panel.BackColor = Color.FromArgb(224, 224, 224);
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.Controls.Add(cancleBtn);
            panel.Controls.Add(deleteBtn);
            panel.Controls.Add(scrollablePanel);
            panel.Controls.Add(selectFilterComboBox);
            panel.Controls.Add(itemIDLabel);
            panel.Controls.Add(itemCustomerNameLabel);
            panel.Controls.Add(itemNameLabel);
            panel.Controls.Add(itemPicBoxLabel);
            panel.Controls.Add(itemPriceLabel);
            panel.Controls.Add(itemStatusLabel);
            panel.Controls.Add(manageOrdersLabel);
            panel.Controls.Add(filterLabel);
            panel.Controls.Add(progressLabel);
            panel.Controls.Add(searchBarLabel);
            panel.Controls.Add(orderProgressBar);
            panel.Location = new Point(119, 54);
            panel.Name = "panel";
            panel.Size = new Size(710, 498);
            panel.TabIndex = 6;
            // 
            // cancleBtn
            // 
            cancleBtn.BackColor = Color.Gray;
            cancleBtn.FlatStyle = FlatStyle.Flat;
            cancleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold);
            cancleBtn.Location = new Point(385, 419);
            cancleBtn.Name = "cancleBtn";
            cancleBtn.Size = new Size(125, 39);
            cancleBtn.TabIndex = 27;
            cancleBtn.Text = "Cancel";
            cancleBtn.UseVisualStyleBackColor = false;
           
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
            // 
            // scrollablePanel
            // 
            scrollablePanel.AutoScroll = true;
         
            scrollablePanel.Location = new Point(36, 165);
            scrollablePanel.Name = "scrollablePanel";
            scrollablePanel.Size = new Size(629, 237);
            scrollablePanel.TabIndex = 25;
           

           
            // 
            // selectFilterComboBox
            // 
            selectFilterComboBox.FormattingEnabled = true;
            selectFilterComboBox.Location = new Point(577, 84);
            selectFilterComboBox.Name = "selectFilterComboBox";
            selectFilterComboBox.Size = new Size(88, 23);
            selectFilterComboBox.TabIndex = 7;
            selectFilterComboBox.Items.AddRange(new object[] { "Item Name", "Username", "ItemID" });
            selectFilterComboBox.SelectedIndex = 0;
            selectFilterComboBox.TextChanged += searchbar_TextChanged;
           
            // 
            // itemIDLabel
            // 
            itemIDLabel.AutoSize = true;
            itemIDLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemIDLabel.ForeColor = Color.Black;
            itemIDLabel.Location = new Point(39, 143);
            itemIDLabel.Name = "itemIDLabel";
            itemIDLabel.Size = new Size(62, 19);
            itemIDLabel.TabIndex = 13;
            itemIDLabel.Text = "Item ID";
            // 
            // itemCustomerNameLabel
            // 
            itemCustomerNameLabel.AutoSize = true;
            itemCustomerNameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemCustomerNameLabel.ForeColor = Color.Black;
            itemCustomerNameLabel.Location = new Point(522, 143);
            itemCustomerNameLabel.Name = "itemCustomerNameLabel";
            itemCustomerNameLabel.Size = new Size(123, 19);
            itemCustomerNameLabel.TabIndex = 18;
            itemCustomerNameLabel.Text = "Customer Name";
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemNameLabel.ForeColor = Color.Black;
            itemNameLabel.Location = new Point(257, 143);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(51, 19);
            itemNameLabel.TabIndex = 14;
            itemNameLabel.Text = "Name";
            // 
            // itemPicBoxLabel
            // 
            itemPicBoxLabel.AutoSize = true;
            itemPicBoxLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemPicBoxLabel.ForeColor = Color.Black;
            itemPicBoxLabel.Location = new Point(157, 143);
            itemPicBoxLabel.Name = "itemPicBoxLabel";
            itemPicBoxLabel.Size = new Size(58, 19);
            itemPicBoxLabel.TabIndex = 17;
            itemPicBoxLabel.Text = "Picture";
            // 
            // itemPriceLabel
            // 
            itemPriceLabel.AutoSize = true;
            itemPriceLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemPriceLabel.ForeColor = Color.Black;
            itemPriceLabel.Location = new Point(346, 143);
            itemPriceLabel.Name = "itemPriceLabel";
            itemPriceLabel.Size = new Size(43, 19);
            itemPriceLabel.TabIndex = 16;
            itemPriceLabel.Text = "Price";
            // 
            // itemStatusLabel
            // 
            itemStatusLabel.AutoSize = true;
            itemStatusLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemStatusLabel.ForeColor = Color.Black;
            itemStatusLabel.Location = new Point(437, 143);
            itemStatusLabel.Name = "itemStatusLabel";
            itemStatusLabel.Size = new Size(53, 19);
            itemStatusLabel.TabIndex = 15;
            itemStatusLabel.Text = "Status";
            // 
            // manageOrdersLabel
            // 
            manageOrdersLabel.AutoSize = true;
            manageOrdersLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageOrdersLabel.ForeColor = Color.Black;
            manageOrdersLabel.Location = new Point(39, 9);
            manageOrdersLabel.Name = "manageOrdersLabel";
            manageOrdersLabel.Size = new Size(175, 28);
            manageOrdersLabel.TabIndex = 12;
            manageOrdersLabel.Text = "Manage Orders";
            // 
            // filterLabel
            // 
            filterLabel.AutoSize = true;
            filterLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterLabel.ForeColor = Color.Black;
            filterLabel.Location = new Point(532, 87);
            filterLabel.Name = "filterLabel";
            filterLabel.Size = new Size(39, 16);
            filterLabel.TabIndex = 9;
            filterLabel.Text = "Filter";
            // 
            // progressLabel
            // 
            progressLabel.AutoSize = true;
            progressLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            progressLabel.ForeColor = Color.Black;
            progressLabel.Location = new Point(361, 16);
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new Size(75, 21);
            progressLabel.TabIndex = 8;
            progressLabel.Text = "Progress";
            // 
            // searchBarLabel
            // 
            searchBarLabel.Location = new Point(440, 58);
            searchBarLabel.Name = "searchBarLabel";
            searchBarLabel.PlaceholderText = "Search orders";
            searchBarLabel.Size = new Size(225, 23);
            searchBarLabel.TabIndex = 6;
            searchBarLabel.TextChanged += searchbar_TextChanged;
            // 
            // orderProgressBar
            // 
            orderProgressBar.Location = new Point(442, 16);
            orderProgressBar.Name = "orderProgressBar";
            orderProgressBar.Size = new Size(225, 23);
            orderProgressBar.TabIndex = 4;
            orderProgressBar.Value = 7;
           

            panel.ResumeLayout(false);
            panel.PerformLayout();
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
            string whereQuery = "SELECT i.ItemID, c.username, i.Price, i.ImageURL, i.Name FROM OrderTable o INNER JOIN Customer c ON o.CustomerID = c.customer_id INNER JOIN Item i ON o.ItemID = i.ItemID where ";

            // Construct the WHERE clause based on the selected filter and search text
            switch (selectFilterComboBox.SelectedItem?.ToString())
            {
                case "ItemID":
                    whereQuery += "i.ItemID LIKE @SearchText ORDER BY CASE WHEN i.ItemID LIKE @SearchTextStart THEN 1 ELSE 2 END";
                    break;
                case "username":
                    whereQuery += "c.username LIKE @SearchText ORDER BY CASE WHEN c.username LIKE @SearchTextStart THEN 1 ELSE 2 END";
                    break;
                case "Item Name":
                  
                    whereQuery += "i.Name LIKE @SearchText ORDER BY CASE WHEN i.Name LIKE @SearchTextStart THEN 1 ELSE 2 END";
                    break;
                default:
                    // Default to searching by Name if no filter is selected
                    whereQuery += "i.Name LIKE @SearchText ORDER BY CASE WHEN i.Name LIKE @SearchTextStart THEN 1 ELSE 2 END";
                    break;
            }

          
            SqlCommand command = new SqlCommand(whereQuery, connection);  
            command.Parameters.AddWithValue("@SearchText", "%" + searchBarLabel.Text.Trim() + "%");
            command.Parameters.AddWithValue("@SearchTextStart", searchBarLabel.Text.Trim() + "%");

            SqlDataReader reade = command.ExecuteReader();

            loadOrderData(reade);

           // connection.Close();
        }

        public void executeSelectQuery()
        {
            SqlConnection connection = new SqlConnection(connectionStringQuery);
            connection.Open();
            SqlCommand command = new SqlCommand(selectQuery, connection);
            SqlDataReader reader = command.ExecuteReader();

            loadOrderData(reader);
        }
        public void loadOrderData(SqlDataReader reader)
        {
            //this.scrollablePanel.Controls.Clear();
            int panel3Location = 12;
            int labelLocation = 14;
            int itemBoxLocation = 3;
            bool onClick = false;
            while (reader.Read())
            {
                string? id = reader["ItemID"].ToString();
                string? username = reader["username"].ToString();
                string? price = reader["Price"].ToString();
                string? imageURL = reader["ImageURL"].ToString();
                string? nameOfItem = reader["Name"].ToString();

                  Label itemID;
                  itemID = new Label();
                  Panel panel3;
                  panel3 = new Panel();
                  PictureBox itemPictureBox;
                  itemPictureBox = new PictureBox();
                  Label itemName;
                  itemName = new Label();
                  Label itemStatus;
                  Label itemCustomer;
                  Label itemPrice;
                itemStatus = new Label();
                itemCustomer = new Label();
                itemPrice = new Label();
                // 
                // itemStatus
                // 
                itemStatus.AutoSize = true;
                itemStatus.BackColor = Color.White;
                itemStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
                itemStatus.ForeColor = Color.Green;
                itemStatus.Location = new Point(397, labelLocation);
                itemStatus.Name = "itemStatus";
                itemStatus.Size = new Size(51, 19);
                itemStatus.TabIndex = 21;
                itemStatus.Text = "Pending";
                // 
                // itemCustomer
                // 
                itemCustomer.AutoSize = true;
                itemCustomer.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
                itemCustomer.ForeColor = Color.Black;
                itemCustomer.Location = new Point(480, labelLocation);
                itemCustomer.Name = "itemCustomer";
                itemCustomer.Size = new Size(51, 19);
                itemCustomer.TabIndex = 22;
                itemCustomer.Text = username;


                // 
                // itemPrice
                // 
                itemPrice.AutoSize = true;
                itemPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
                itemPrice.ForeColor = Color.Black;
                itemPrice.Location = new Point(307, labelLocation);
                itemPrice.Name = "itemPrice";
                itemPrice.Size = new Size(51, 19);
                itemPrice.TabIndex = 20;
                itemPrice.Text = price;


                // 
                // itemName
                // 
                itemName.AutoSize = true;
                itemName.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
                itemName.ForeColor = Color.Black;
                itemName.Location = new Point(215, labelLocation);
                itemName.Name = "itemName";
                itemName.Size = new Size(51, 19);
                itemName.TabIndex = 19;
                itemName.Text = nameOfItem;
                // 
                // itemPictureBox
                // 
                itemPictureBox.BackColor = Color.Black;
                itemPictureBox.Location = new Point(115, itemBoxLocation);
                itemPictureBox.Name = "itemPictureBox";
                itemPictureBox.Size = new Size(58, 46);
                itemPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                itemPictureBox.TabIndex = 0;
                itemPictureBox.TabStop = false;
                itemPictureBox.Image = System.Drawing.Image.FromFile(imageURL);
                // 
                // panel3
                // 
                panel3.BackColor = Color.White;
                panel3.Controls.Add(itemStatus);
                panel3.Controls.Add(itemCustomer);
                panel3.Controls.Add(itemID);
                panel3.Controls.Add(itemPictureBox);
                panel3.Controls.Add(itemPrice);
                panel3.Controls.Add(itemName);
                panel3.Location = new Point(6, panel3Location);
                panel3.Name = "panel3";
                panel3.Size = new Size(603, 65);
                panel3.TabIndex = 23;
                panel3.Click += (sender, e) =>
                {
                    if (onClick)
                    {
                        onClick = false;
                        panel3.BackColor = Color.White;
                    }
                    else
                    {
                        onClick = true;
                        panel3.BackColor = Color.Green;
                    }

                };
                // 
                // itemID
                // 
                itemID.AutoSize = true;
                itemID.BackColor = Color.DimGray;
                itemID.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
                itemID.ForeColor = Color.Black;
                itemID.Location = new Point(18, labelLocation);
                itemID.Name = "itemID";
                itemID.Size = new Size(18, 19);
                itemID.TabIndex = 19;
                itemID.Text = id;
                ((System.ComponentModel.ISupportInitialize)itemPictureBox).EndInit();
                scrollablePanel.Controls.Add(panel3);
                panel3.SuspendLayout();
                panel3Location += 70;
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
