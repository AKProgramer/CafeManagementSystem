using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
namespace CafeManagementSystem

{
    public partial class Menu : Form
    {
        string insertQuery = "INSERT INTO OrderTable (CustomerID, Quantity, ItemID) VALUES (@CustomerID, @Quantity, @ItemID)";
        private const string connectionString = "Data Source=CODING-0\\SQLEXPRESS;Initial Catalog=database_project;Integrated Security=True";
        string itemCountQuery = "select count(ItemID) from OrderTable where CustomerID=@CustomerId";

        OrderPanel orderPanel;
        private LoginForm loginForm;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
             (
                 int nLeftRect,
                 int nRightRect,
                 int nTopReact,
                 int nBottomRect,
                 int nWidthEllipse,
                 int nHeightEllipse

             );


        public Menu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnMenu.Height;
            pnlNav.Top = btnMenu.Top;
            pnlNav.Left = btnMenu.Left;
            btnMenu.BackColor = Color.FromArgb(46, 51, 73);
            AddItemsToCategories();
            if (functionForItemCount() == 0)
            {
                itemCount.Hide();
            }
            else
            {
                itemCount.Show();
            }

            orderPanel = new OrderPanel();
            loginForm = new LoginForm();
        }
        public int functionForItemCount()
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(itemCountQuery, connection))
                {
                    command.Parameters.AddWithValue("@CustomerId", 17);
                    try
                    {
                        connection.Open();
                        count = (int)command.ExecuteScalar();
                        itemCount.Text = count.ToString();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            return count;
        }
        private void AddItemsToCategories()
        {
            try
            {
                // Create a new SqlConnection using the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Define your SQL query
                    string query = "SELECT i.ItemID, i.Name, i.Price, i.ImageURL, i.Time FROM Item i";

                    // Create a SqlCommand object with the query and the connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // for development purpose
                        command.Parameters.AddWithValue("@CustomerID", 17);
                        // Execute the query and obtain a SqlDataReader
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Loop through the results and create panels dynamically
                            while (reader.Read())
                            {
                                // Extract data from the reader

                                string? name = reader["Name"].ToString();
                                decimal price = Convert.ToDecimal(reader["Price"]);
                                string? imagePath = reader["ImageURL"].ToString();
                                int itemId = Convert.ToInt32(reader["ItemID"]);
                                string? time = reader["Time"].ToString();
                                // Create a new panel
                                Panel panel = new Panel();
                                panel.BackColor = System.Drawing.Color.Black;
                                panel.Size = new System.Drawing.Size(150, 195);

                                // Create a PictureBox and set its properties
                                PictureBox pictureBox = new PictureBox();
                                pictureBox.Size = new System.Drawing.Size(100, 100);
                                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                pictureBox.Image = System.Drawing.Image.FromFile(imagePath); // Set your image path here
                                pictureBox.Location = new System.Drawing.Point(30, 10);

                                // Create labels for name and price
                                Label nameLabel = new Label();
                                nameLabel.Text = "Name: " + name;
                                nameLabel.Location = new System.Drawing.Point(10, 130);

                                Label priceLabel = new Label();
                                priceLabel.Text = "Price: " + price.ToString("C"); // Format price as currency
                                priceLabel.Location = new System.Drawing.Point(10, 150);
                                // Button
                                Button addToCart = new Button();
                                addToCart.Text = "Add to Cart";
                                addToCart.Location = new System.Drawing.Point(10, 170);
                                addToCart.Size = new Size(120, 25);
                                bool clickOnlyOnce = false;
                                addToCart.Click += (sender, e) =>
                                {
                                    if (clickOnlyOnce == false)
                                    {
                                        clickOnlyOnce = true;
                                        SqlConnection connection1 = new SqlConnection(connectionString);
                                        connection1.Open();
                                        SqlCommand command1 = new SqlCommand(insertQuery, connection1);

                                        // Add parameters to prevent SQL injection
                                        command1.Parameters.AddWithValue("@CustomerID", 17);
                                        command1.Parameters.AddWithValue("@Quantity", 1);
                                        command1.Parameters.AddWithValue("@ItemID", itemId);
                                        command1.ExecuteNonQuery();
                                        functionForItemCount();
                                        itemCount.Show();
                                    }
                                };
                                // Add controls to the panel
                                panel.Controls.Add(pictureBox);
                                panel.Controls.Add(nameLabel);
                                panel.Controls.Add(priceLabel);
                                panel.Controls.Add(addToCart);

                                if (time == "breakfast" || time=="Breakfast")
                                    breakfastFlowlayout.Controls.Add(panel);
                                else if (time == "Lunch" || time == "lunch")
                                    lunchFlowlayout.Controls.Add(panel);

                            }


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMenu.Height;
            pnlNav.Top = btnMenu.Top;
            pnlNav.Left = btnMenu.Left;
            btnMenu.BackColor = Color.FromArgb(46, 51, 73);
            orderPanel.loadOrderFromDB();
            if (functionForItemCount() == 0)
            {
                itemCount.Hide();
            }
            else
            {
                itemCount.Show();
                functionForItemCount();
            }
            this.scrollableMenu.Show();

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnOrder.Height;
            pnlNav.Top = btnOrder.Top;
            pnlNav.Left = btnOrder.Left;
            btnOrder.BackColor = Color.FromArgb(46, 51, 73);
            orderPanel.loadOrderFromDB();
            this.scrollableMenu.Hide();
            itemCount.Hide();
            Controls.Add(orderPanel.nonScrollablePanel);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPayment.Height;
            pnlNav.Top = btnPayment.Top;
            pnlNav.Left = btnPayment.Left;
            btnPayment.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLogout.Height;
            pnlNav.Top = btnLogout.Top;
            pnlNav.Left = btnLogout.Left;
            btnLogout.BackColor = Color.FromArgb(46, 51, 73);
            this.Hide();
            loginForm.Show();

        }
        private void btnMenu_Leave(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnLogout_Leave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnPayment_Leave(object sender, EventArgs e)
        {
            btnPayment.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnOrder_Leave(object sender, EventArgs e)
        {
            btnOrder.BackColor = Color.FromArgb(24, 30, 54);
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
