using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace CafeManagementSystem
{
    internal class OrderPanel
    {
        // Define the delete query
        string deleteQuery = "DELETE FROM OrderTable WHERE CustomerID = @CustomerID AND ItemID = @ItemID";
        string deleteAllItems = "DELETE FROM OrderTable WHERE CustomerID = @CustomerID";

        //queries used here
        string query = "SELECT i.Name,i.ItemID, i.Price, i.ImageURL, o.Quantity FROM OrderTable o INNER JOIN Item i ON o.ItemID = i.ItemID where CustomerID=@CustomerID";

        string queryForUpdateQuantity = "UPDATE OrderTable SET Quantity = @NewQuantity WHERE ItemID = @ItemID";
        string queryForUpdatingItemPriceLabel = "SELECT (o.Quantity * i.Price) FROM  OrderTable o INNER JOIN Item i ON o.ItemID = i.ItemID where o.ItemID=@ItemID";
        string queryForTotal = "SELECT sum(i.Price * o.Quantity) FROM OrderTable o INNER JOIN Item i ON o.ItemID = i.ItemID where CustomerID= @CustomerID";
        //ends here

        private const string connectionString = "Data Source=CODING-0\\SQLEXPRESS;Initial Catalog=database_project;Integrated Security=True";
        public Panel nonScrollablePanel;
        private Label shoppingCartLabel;
        private Button removeAll;
        private Panel scrollablePanel;
        private Label subTotalLabel;
        private Label totalPriceLabel;
        //Those that will make 
        
        //here it's end

        private Panel staticLine;
        private Button button4;
        private PaymentOptionPanel paymentOptionPanel;
        public  OrderPanel()
        {
            nonScrollablePanel = new Panel();
            shoppingCartLabel = new Label();
            removeAll = new Button();
            staticLine = new Panel();
            scrollablePanel = new Panel();
            subTotalLabel = new Label();
            totalPriceLabel = new Label();
            button4 = new Button();
            nonScrollablePanel.SuspendLayout();
            scrollablePanel.SuspendLayout();
            paymentOptionPanel = new PaymentOptionPanel();
           
          
            // 
            // nonScrollablePanel
            // 
            nonScrollablePanel.AutoScroll = true;
            nonScrollablePanel.BackColor = Color.FromArgb(64, 64, 64);
            nonScrollablePanel.Controls.Add(button4);
            nonScrollablePanel.Controls.Add(totalPriceLabel);
            nonScrollablePanel.Controls.Add(subTotalLabel);
            nonScrollablePanel.Controls.Add(scrollablePanel);
            nonScrollablePanel.Controls.Add(staticLine);
            nonScrollablePanel.Controls.Add(removeAll);
            nonScrollablePanel.Controls.Add(shoppingCartLabel);
         
            nonScrollablePanel.Location = new Point(119, 48);
            nonScrollablePanel.Name = "nonScrollablePanel";
          
            nonScrollablePanel.Size = new Size(708, 486);
            nonScrollablePanel.TabIndex = 6;
            // 
            // shoppingCartLabel
            // 
            shoppingCartLabel.AutoSize = true;
            shoppingCartLabel.Font = new System.Drawing.Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shoppingCartLabel.ForeColor = Color.White;
            shoppingCartLabel.Location = new Point(33, 24);
            shoppingCartLabel.Name = "shoppingCartLabel";
            shoppingCartLabel.Size = new Size(132, 22);
            shoppingCartLabel.TabIndex = 0;
            shoppingCartLabel.Text = "Shoping Cart";
            // 
            // removeAll
            // 
            removeAll.BackColor = Color.Black;
            removeAll.FlatAppearance.BorderSize = 0;
            removeAll.FlatStyle = FlatStyle.Flat;
            removeAll.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeAll.ForeColor = Color.Red;
            removeAll.Location = new Point(662, 21);
            removeAll.Name = "removeAll";
            removeAll.Size = new Size(25, 25);
            removeAll.TabIndex = 7;
            removeAll.Text = "X";
            removeAll.UseVisualStyleBackColor = false;
            removeAll.Click += (sender, e) =>
                {
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    SqlCommand command3 = new SqlCommand(deleteAllItems, connection);
                    //For Development
                    command3.Parameters.AddWithValue("@CustomerID", 17);
                    int result = command3.ExecuteNonQuery();
                    if (result > 0)
                    {
                        loadOrderFromDB();
                    }
                    else
                    {
                        MessageBox.Show("Error in query");
                    }
                    connection.Close();
                };
            // 
            // staticLine
            // 
            staticLine.BackColor = Color.Black;
            staticLine.Location = new Point(196, 339);
            staticLine.Name = "staticLine";
            staticLine.Size = new Size(464, 3);
            staticLine.TabIndex = 9;
            // 
            // scrollablePanel
            // 
            scrollablePanel.AutoScroll = true;
           
            scrollablePanel.Location = new Point(17, 73);
            scrollablePanel.Name = "scrollablePanel";
            scrollablePanel.Size = new Size(670, 260);
            scrollablePanel.TabIndex = 11;
            scrollablePanel.BackColor = Color.FromArgb(64, 64, 55);
           
            subTotalLabel.AutoSize = true;
            subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            subTotalLabel.Location = new Point(398, 355);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new Size(87, 20);
            subTotalLabel.TabIndex = 12;
            subTotalLabel.Text = "Sub-Total";
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalPriceLabel.Location = new Point(585, 355);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(71, 25);
            totalPriceLabel.TabIndex = 13;
            // query for total Price
       

            // 
            // button4
            // 
            button4.BackColor = Color.Chocolate;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new System.Drawing.Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(398, 383);
            button4.Name = "button4";
            button4.Size = new Size(258, 38);
            button4.TabIndex = 14;
            button4.Text = "Make Order";
            button4.UseVisualStyleBackColor = false;
            button4.Click +=(sender, e)=>
            {
               // this.nonScrollablePanel.Hide();
               nonScrollablePanel.Controls.Clear();
                nonScrollablePanel.Controls.Add(paymentOptionPanel.panelContainingPayOptionButtons);
                
            };
            // 
            // Order
            // 

            nonScrollablePanel.ResumeLayout(false);
            nonScrollablePanel.PerformLayout();
            scrollablePanel.ResumeLayout(false);
            scrollablePanel.PerformLayout();
           
        }

        private void Button4_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void functionForCalculatingTotal()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command3 = new SqlCommand(queryForTotal, connection);
            //For Development
            command3.Parameters.AddWithValue("@CustomerID", 17);
            object result = command3.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                // Convert the result to float and update the total price label
                float totalPriceFromDB = Convert.ToSingle(result);
                totalPriceLabel.Text = totalPriceFromDB.ToString();
            }
            else
            {
                // Handle case where there are no orders for the specified customer
                totalPriceLabel.Text = "0";
            }
            connection.Close();
        }
        public void loadOrderFromDB()
        {
            functionForCalculatingTotal();
            try
            {
               

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    //For Development
                    command.Parameters.AddWithValue("@CustomerID", 17);
                    SqlDataReader reader = command.ExecuteReader();
                    scrollablePanel.Controls.Clear();

                    int yOffsetForRemoveItemBtn = 57; // Vertical offset for positioning controls
                    int yOffsetForRemoveItemPriceLabel= 21;  
                    int yOffsetForRemoveBtnAndAddBtn= 52;  
                    int yOffsetForItemName= 20;  
                    int yOffsetForItemPicture = 0;  
                    int yOffsetForQuantityLabel = 63;  
                   
                    while (reader.Read())
                    {
                        // Read data from the reader
                        string? name = reader["Name"].ToString();
                        decimal itemPrice = Convert.ToDecimal(reader["Price"]);
                        string? imageURL = reader["ImageURL"].ToString();
                        int quantity = Convert.ToInt32(reader["Quantity"]);
                        int itemId = Convert.ToInt32(reader["ItemID"]);
                         Button removeItemBtn=new Button();
                         Label itemPriceLabel = new Label();
                         Button removeBtn = new Button();
                         Button addBtn = new Button();
                         Label itemName= new Label();
                         PictureBox itemPicture=new PictureBox();
                         Label quantityLabel=new Label();
                        // 
                        // removeItemBtn
                        // 
                        removeItemBtn.BackColor = Color.Silver;
                        removeItemBtn.FlatAppearance.BorderSize = 0;
                        removeItemBtn.FlatStyle = FlatStyle.System;
                        removeItemBtn.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
                        removeItemBtn.ForeColor = Color.Red;
                        removeItemBtn.Location = new Point(568, yOffsetForRemoveItemBtn);
                        removeItemBtn.Name = "removeItemBtn";
                        removeItemBtn.Size = new Size(75, 23);
                        removeItemBtn.TabIndex = 15;
                        removeItemBtn.Text = "Remove";
                        removeItemBtn.UseVisualStyleBackColor = false;
                        removeItemBtn.Click += (sender, e) => {
                            using (SqlConnection connection1 = new SqlConnection(connectionString))
                            {
                                // Open the connection
                                connection1.Open();

                                // Create a SqlCommand object with the delete query and the connection
                                using (SqlCommand command1 = new SqlCommand(deleteQuery, connection1))
                                {
                                    // Add parameters to prevent SQL injection
                                    command1.Parameters.AddWithValue("@CustomerID", 17);
                                    command1.Parameters.AddWithValue("@ItemID", itemId);

                                    // Execute the delete query
                                    int rowsAffected = command1.ExecuteNonQuery();
                                    if(rowsAffected>0) {
                                        loadOrderFromDB();
                                        SqlConnection connection = new SqlConnection(connectionString);
                                        connection.Open();
                                        SqlCommand command3 = new SqlCommand(queryForTotal, connection);
                                        //For Development
                                        command3.Parameters.AddWithValue("@CustomerID", 17);
                                        object result = command3.ExecuteScalar();
                                        if (result != null && result != DBNull.Value)
                                        {
                                            // Convert the result to float and update the total price label
                                            float totalPriceFromDB = Convert.ToSingle(result);
                                            totalPriceLabel.Text = totalPriceFromDB.ToString();
                                        }
                                        else
                                        {
                                            // Handle case where there are no orders for the specified customer
                                            totalPriceLabel.Text = "0";
                                        }
                                        connection.Close();



                                    }
                                }
                            }
                        };
                        // 
                        // itemPriceLabel
                        // 
                        itemPriceLabel.AutoSize = true;
                        itemPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                        itemPriceLabel.Location = new Point(586, yOffsetForRemoveItemPriceLabel);
                        itemPriceLabel.Name = "itemPriceLabel";
                        itemPriceLabel.Size = new Size(54, 20);
                        itemPriceLabel.TabIndex = 14;
                        itemPriceLabel.Text = itemPrice.ToString();
                       
                        // 
                        // removeBtn
                        // 
                        removeBtn.Font = new System.Drawing.Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                        removeBtn.Location = new Point(409, yOffsetForRemoveBtnAndAddBtn);
                        removeBtn.Name = "removeBtn";
                        removeBtn.Size = new Size(32, 32);
                        removeBtn.TabIndex = 12;
                        removeBtn.Text = "-";
                        removeBtn.UseVisualStyleBackColor = true;
                        removeBtn.BackColor = Color.Black;
                        // 
                        // addBtn
                        // 
                        addBtn.Font = new System.Drawing.Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                        addBtn.Location = new Point(333, yOffsetForRemoveBtnAndAddBtn);
                        addBtn.Name = "addBtn";
                        addBtn.Size = new Size(32, 32);
                        addBtn.TabIndex = 11;
                        addBtn.Text = "+";
                        addBtn.UseVisualStyleBackColor = true;
                        addBtn.BackColor = Color.Black;
                        // 
                        // itemName
                        // 
                        itemName.AutoSize = true;
                        itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                        itemName.Location = new Point(179, yOffsetForItemName);
                        itemName.Name = "itemName";
                        itemName.Size = new Size(102, 20);
                        itemName.TabIndex = 10;
                        itemName.Text = name;
                        // 
                        // itemPicture
                        // 
                        itemPicture.BackColor = Color.Gray;
                        itemPicture.Location = new Point(0, yOffsetForItemPicture);
                        itemPicture.Name = "itemPicture";
                        itemPicture.Size = new Size(100, 111);
                        itemPicture.TabIndex = 9;
                        itemPicture.TabStop = false;
                        itemPicture.SizeMode = PictureBoxSizeMode.Zoom;
                        itemPicture.Image= System.Drawing.Image.FromFile(imageURL);

                        // 
                        // quantityLabel
                        // 
                        quantityLabel.AutoSize = true;
                        quantityLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
                        quantityLabel.Location = new Point(381, yOffsetForQuantityLabel);
                        quantityLabel.Name = "quantityLabel";
                        quantityLabel.Size = new Size(15, 17);
                        quantityLabel.TabIndex = 13;
                        quantityLabel.Text = quantity.ToString();
                        //initial queries
                       
                        // adding all 
                        scrollablePanel.Controls.Add(removeItemBtn);
                        scrollablePanel.Controls.Add(itemPriceLabel);
                        scrollablePanel.Controls.Add(quantityLabel);
                        scrollablePanel.Controls.Add(removeBtn);
                        scrollablePanel.Controls.Add(addBtn);
                        scrollablePanel.Controls.Add(itemName);
                        scrollablePanel.Controls.Add(itemPicture);

                        // onclick function are here
                       /* removeBtn.Click += (sender, e) => RemoveBtn_Click(sender, e, quantity, quantityLabel); // Pass -1 for decrement
                        addBtn.Click += (sender, e) => AddBtn_Click(sender, e, quantity, quantityLabel);*/
                        removeBtn.Click += (sender, e) =>
                        {
                            if (quantity > 1)
                            {
                                quantity--;
                                quantityLabel.Text = quantity.ToString();
                                itemPriceLabel.Text = (itemPrice * quantity).ToString();
                                decimal total = decimal.Parse(totalPriceLabel.Text);
                                total -= itemPrice;
                                totalPriceLabel.Text = total.ToString();
                               /* quantityLabel.Text = quantity.ToString();
                                SqlConnection connection = new SqlConnection(connectionString);
                                connection.Open();
                                SqlCommand command1 = new SqlCommand(queryForUpdateQuantity,connection);
                                command1.Parameters.AddWithValue("@NewQuantity", quantity);
                                command1.Parameters.AddWithValue("@ItemID", itemId);
                                SqlCommand command2 = new SqlCommand(queryForUpdatingItemPriceLabel, connection);
                                command2.Parameters.AddWithValue("@ItemID", itemId);
                                SqlCommand command3 = new SqlCommand(queryForTotal, connection);
                                command3.Parameters.AddWithValue("@ItemID", itemId);
                                float itemPriceFromDB = Convert.ToSingle(command2.ExecuteScalar());
                                float totalPriceFromDB = Convert.ToSingle(command3.ExecuteScalar());
                                totalPriceLabel.Text = totalPriceFromDB.ToString();
                                itemPriceLabel.Text = itemPriceFromDB.ToString();
                                 int rowsAffected = command1.ExecuteNonQuery();
                                if (rowsAffected > 0 || itemPriceFromDB >= 0 || totalPriceFromDB >= 0)
                                {
                                    Console.WriteLine("Quantity updated successfully.");
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update quantity.");
                                }*/

                            }
                           

                        };
                        addBtn.Click += (sender, e) =>
                        {
                            quantity++;
                            quantityLabel.Text = quantity.ToString();
                            itemPriceLabel.Text = (itemPrice * quantity).ToString();
                            decimal total = decimal.Parse(totalPriceLabel.Text);
                            total += itemPrice;
                            totalPriceLabel.Text = total.ToString();

                            /* SqlConnection connection = new SqlConnection(connectionString);
                             connection.Open();
                             SqlCommand command1 = new SqlCommand(queryForUpdateQuantity, connection);
                             command1.Parameters.AddWithValue("@NewQuantity", quantity);
                             command1.Parameters.AddWithValue("@ItemID", itemId);
                             SqlCommand command2 = new SqlCommand(queryForUpdatingItemPriceLabel, connection);
                             command2.Parameters.AddWithValue("@ItemID", itemId);
                             SqlCommand command3 = new SqlCommand(queryForTotal, connection);
                             float itemPriceFromDB = Convert.ToSingle(command2.ExecuteScalar());
                             float totalPriceFromDB = Convert.ToSingle(command3.ExecuteScalar());
                             totalPriceLabel.Text = totalPriceFromDB.ToString();
                             itemPriceLabel.Text = itemPriceFromDB.ToString();
                             int rowsAffected = command1.ExecuteNonQuery();
                             if (rowsAffected > 0 || itemPriceFromDB >= 0 || totalPriceFromDB >= 0)
                             {
                                 Console.WriteLine("Quantity updated successfully.");
                             }
                             else
                             {
                                 MessageBox.Show("Failed to update quantity.");
                             }*/
                        };
                        yOffsetForRemoveItemBtn += 168;
                         yOffsetForRemoveItemPriceLabel +=168;
                         yOffsetForRemoveBtnAndAddBtn +=168;
                         yOffsetForItemName +=168;
                         yOffsetForItemPicture +=168;
                         yOffsetForQuantityLabel +=168;

                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order data: " + ex.Message);
            }
        }
        private void RemoveBtn_Click(object sender, EventArgs e, int quantity, Label quantityLabel)
        {
            if (quantity > 1)
            {
                quantity--;
                quantityLabel.Text = quantity.ToString();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e, int quantity, Label quantityLabel)
        {
            if (quantity > 1)
            {
                quantity++;
                quantityLabel.Text = quantity.ToString();
            }
        }
    }
}
