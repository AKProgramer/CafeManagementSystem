using System.Data.SqlClient;
namespace CafeManagementSystem.AdminModule
{
    public partial class AdminForm : Form
    {
        private const string connectionStringQuery = "Data Source=CODING-0\\SQLEXPRESS;Initial Catalog=database_project;Integrated Security=True";
        private string totalRegisteredUsers = "select count(c.customer_id) from Customer c";
        private string totalOrdersQuery = "select count(o.OrderID) from OrderTable o";
        private string totalSalesQuery = "select sum(t.Price) from OrderTable o inner join Item t on o.ItemID = t.ItemID";
        private string top3CustomersQuery = "SELECT TOP(3) s.CustomerID, s.order_per_customer, c.* FROM (SELECT CustomerID, COUNT(ItemID) AS order_per_customer FROM OrderTable GROUP BY CustomerID) AS s INNER JOIN Customer c ON s.CustomerID = c.customer_id order by s.order_per_customer desc;";
        private string top3OrdersQuery = "SELECT top(3)  s.order_per_customer, i.* FROM (SELECT ItemID, COUNT(CustomerID) AS order_per_customer FROM OrderTable GROUP BY ItemID) AS s INNER JOIN Item i ON s.ItemID = i.ItemID ORDER BY s.order_per_customer DESC;";
        ManageCustomerPanel manageCustomerPanel;
        LoginForm loginForm;
        AddNewItemPanel newItemPanel;
        ManageOrdersPanel manageOrdersPanel;
        FeedbackResponsePanel feedbackResponse;
        

        public AdminForm()
        {
            InitializeComponent();
            loadAnalytics();
            manageCustomerPanel = new ManageCustomerPanel();
            loginForm = new LoginForm();
            newItemPanel = new AddNewItemPanel();
            manageOrdersPanel = new ManageOrdersPanel();
            feedbackResponse = new FeedbackResponsePanel();
        }
        public void loadAnalytics()
        {
            using (SqlConnection connection = new SqlConnection(connectionStringQuery))
            {
                connection.Open();

                int totalRegisteredUser = Convert.ToInt32(ExecuteScalarQuery(totalRegisteredUsers, connection));
                int totalOrders = Convert.ToInt32(ExecuteScalarQuery(totalOrdersQuery, connection));
                int totalSales = Convert.ToInt32(ExecuteScalarQuery(totalSalesQuery, connection));
                totalRegisteredUserLabel.Text = totalRegisteredUser.ToString();
                totalOrdersFromCustomers.Text = totalOrders.ToString();
                totalSalesFromOrders.Text = totalSales.ToString() + "$";
                SqlCommand command = new SqlCommand(top3CustomersQuery, connection);
                SqlDataReader reader = command.ExecuteReader();
                int panelLocation = 20;
                int cusNameLocation = 28;
                int cusPasswordLocation = 0;
                int countForCustomerLocation = 11;
                int i = 0;
                while (reader.Read())
                {
                    int customerId = Convert.ToInt32(reader["CustomerID"]);
                    int orderPerCustomer = Convert.ToInt32(reader["order_per_customer"]);
                    string username = reader["username"].ToString();
                    string email = reader["email"].ToString();
                    string password = reader["password"].ToString();
                    Label countForCustomers;
                    Label cusIDLabel;
                    Label cusNameLabel;
                    Label cusPasswordLabel;
                    Label cusEmailLabel;
                    countForCustomers = new Label();
                    cusIDLabel = new Label();
                    cusNameLabel = new Label();
                    cusPasswordLabel = new Label();
                    cusEmailLabel = new Label();
                    FlowLayoutPanel panelContainingCustomerInfo;
                    panelContainingCustomerInfo = new FlowLayoutPanel();
                    // 
                    // countForCustomers
                    //

                    ++i;
                    countForCustomers.AutoSize = true;
                    countForCustomers.Font = new System.Drawing.Font("Georgia", 20.25F, FontStyle.Regular);
                    countForCustomers.ForeColor = Color.Black;
                    countForCustomers.Location = new Point(20, countForCustomerLocation);
                    countForCustomers.Name = "countForCustomers";
                    countForCustomers.Size = new Size(20, 38);
                    countForCustomers.TabIndex = 1;
                    countForCustomers.Text = i.ToString();
                    // 
                    // cusNameLabel
                    // 
                    cusNameLabel.AutoSize = true;
                    cusNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, FontStyle.Regular);
                    cusNameLabel.ForeColor = Color.Black;
                    cusNameLabel.Location = new Point(73, cusNameLocation);
                    cusNameLabel.Name = "cusNameLabel";
                    //cusNameLabel.Padding = new Padding(40, 5, 0, 0);
                    cusNameLabel.Size = new Size(99, 28);
                    cusNameLabel.TabIndex = 1;
                    cusNameLabel.Text = username;
                    // 
                    // cusPasswordLabel
                    // 
                    cusPasswordLabel.AutoSize = true;
                    cusPasswordLabel.Font = new System.Drawing.Font("Calibri", 14.25F, FontStyle.Regular);
                    cusPasswordLabel.ForeColor = Color.Black;
                    cusPasswordLabel.Location = new Point(178, cusNameLocation);
                    cusPasswordLabel.Name = "cusPasswordLabel";
                    //cusPasswordLabel.Padding = new Padding(40, 5, 0, 0);
                    cusPasswordLabel.Size = new Size(99, 28);
                    cusPasswordLabel.TabIndex = 2;
                    cusPasswordLabel.Text = password;
                    // 
                    // cusEmailLabel
                    // 
                    cusEmailLabel.AutoSize = true;
                    cusEmailLabel.Font = new System.Drawing.Font("Calibri", 14.25F, FontStyle.Regular);
                    cusEmailLabel.ForeColor = Color.Black;
                    cusEmailLabel.Location = new Point(283, cusNameLocation);
                    cusEmailLabel.Name = "cusEmailLabel";
                    // cusEmailLabel.Padding = new Padding(40, 5, 0, 0);
                    cusEmailLabel.Size = new Size(99, 28);
                    cusEmailLabel.TabIndex = 3;
                    cusEmailLabel.Text = email;
                    // 
                    // cusIDLabel
                    // 
                    cusIDLabel.AutoSize = true;
                    cusIDLabel.Font = new System.Drawing.Font("Calibri", 14.25F, FontStyle.Regular);
                    cusIDLabel.ForeColor = Color.Black;
                    cusIDLabel.Location = new Point(3, 0);
                    cusIDLabel.Name = "cusIDLabel";
                    // cusIDLabel.Padding = new Padding(5, 5, 0, 0);
                    cusIDLabel.Size = new Size(64, 28);
                    cusIDLabel.TabIndex = 0;
                    cusIDLabel.Text = customerId.ToString();

                    panelContainingCustomerInfo.BackColor = Color.White;
                    panelContainingCustomerInfo.Controls.Add(cusIDLabel);
                    panelContainingCustomerInfo.Controls.Add(cusNameLabel);
                    panelContainingCustomerInfo.Controls.Add(cusPasswordLabel);
                    panelContainingCustomerInfo.Controls.Add(cusEmailLabel);
                    panelContainingCustomerInfo.Location = new Point(58, panelLocation);
                    panelContainingCustomerInfo.Name = "panelContainingCustomerInfo";
                    panelContainingCustomerInfo.Size = new Size(532, 38);
                    panelContainingCustomerInfo.TabIndex = 0;

                    panelContainingCustomerInfo.ResumeLayout(false);
                    panelContainingCustomerInfo.PerformLayout();
                    panelContainingCustomerInfo.SuspendLayout();
                    topCustomerPanel.Controls.Add(countForCustomers);
                    topCustomerPanel.Controls.Add(panelContainingCustomerInfo);
                    panelLocation += 45;
                    cusNameLocation += 30;
                    cusPasswordLocation += 30;
                    countForCustomerLocation += 40;
                }
                reader.Close();
                SqlCommand newCmd = new SqlCommand(top3OrdersQuery, connection);
                SqlDataReader newReader = newCmd.ExecuteReader();
                int panelContainingOrderInfoLocation = 48;
                int itemPictureBoxLocation = 3;
                int itemNameLabelLocation = 15;
                int countForOrdersLocation = 50;
                int j = 0;
                while (newReader.Read())
                {
                    string imageUrl = (newReader["ImageURL"]).ToString();
                    string itemName = (newReader["Name"]).ToString();
                    string price = newReader["Price"].ToString();
                    string orderPerCustomer = newReader["order_per_customer"].ToString();
                    string time = newReader["Time"].ToString();
                    PictureBox itemPictureBox;
                    Label itemNameLabel;
                    Label itemPriceLabel;
                    Label itemOrderPerCLabel;
                    Label itemTime;
                    Label countForOrders;
                    FlowLayoutPanel panelContainingOrderInfo;
                    itemPictureBox = new PictureBox();
                    itemNameLabel = new Label();
                    itemPriceLabel = new Label();
                    itemOrderPerCLabel = new Label();
                    countForOrders = new Label();
                    itemTime = new Label();
                    panelContainingOrderInfo = new FlowLayoutPanel();
                    ((System.ComponentModel.ISupportInitialize)itemPictureBox).BeginInit();
                    ++j;
                    // 
                    // countForOrders
                    // 
                    countForOrders.AutoSize = true;
                    countForOrders.Font = new System.Drawing.Font("Georgia", 20.25F, FontStyle.Regular);
                    countForOrders.ForeColor = Color.Black;
                    countForOrders.Location = new Point(20, countForOrdersLocation);
                    countForOrders.Name = "countForOrders";
                    countForOrders.Size = new Size(27, 31);
                    countForOrders.TabIndex = 2;
                    countForOrders.Text = j.ToString();
                    // 
                    // panelContainingOrderInfo
                    // 
                    panelContainingOrderInfo.BackColor = Color.White;
                    panelContainingOrderInfo.Controls.Add(itemPictureBox);
                    panelContainingOrderInfo.Controls.Add(itemNameLabel);
                    panelContainingOrderInfo.Controls.Add(itemPriceLabel);
                    panelContainingOrderInfo.Controls.Add(itemOrderPerCLabel);
                    panelContainingOrderInfo.Controls.Add(itemTime);
                    panelContainingOrderInfo.Location = new Point(58, panelContainingOrderInfoLocation);
                    panelContainingOrderInfo.Name = "panelContainingOrderInfo";
                    panelContainingOrderInfo.Size = new Size(532, 51);
                    panelContainingOrderInfo.TabIndex = 1;
                    // 
                    // itemPictureBox
                    // 
                    itemPictureBox.BackColor = Color.Gray;
                    itemPictureBox.Location = new Point(3, itemPictureBoxLocation);
                    itemPictureBox.Name = "itemPictureBox";
                    itemPictureBox.Size = new Size(50, 51);
                    itemPictureBox.TabIndex = 0;
                    itemPictureBox.TabStop = false;
                    itemPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    itemPictureBox.Image = Image.FromFile(imageUrl);
                    // 
                    // itemNameLabel
                    // 
                    itemNameLabel.AutoSize = true;
                    itemNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    itemNameLabel.ForeColor = Color.Black;
                    itemNameLabel.Location = new Point(121, itemNameLabelLocation);
                    itemNameLabel.Margin = new Padding(65, 15, 3, 0);
                    itemNameLabel.Name = "itemNameLabel";
                    itemNameLabel.Size = new Size(43, 17);
                    itemNameLabel.TabIndex = 1;
                    itemNameLabel.Text = itemName;
                    // 
                    // itemPriceLabel
                    // 
                    itemPriceLabel.AutoSize = true;
                    itemPriceLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    itemPriceLabel.ForeColor = Color.Red;
                    itemPriceLabel.Location = new Point(197, itemNameLabelLocation);
                    itemPriceLabel.Margin = new Padding(30, 15, 3, 0);
                    itemPriceLabel.Name = "itemPriceLabel";
                    itemPriceLabel.Size = new Size(50, 17);
                    itemPriceLabel.TabIndex = 2;
                    itemPriceLabel.Text = price;
                    // 
                    // itemOrderPerCLabel
                    // 
                    itemOrderPerCLabel.AutoSize = true;
                    itemOrderPerCLabel.BackColor = Color.WhiteSmoke;
                    itemOrderPerCLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    itemOrderPerCLabel.ForeColor = Color.Green;
                    itemOrderPerCLabel.Location = new Point(300, itemNameLabelLocation);
                    itemOrderPerCLabel.Margin = new Padding(50, 15, 3, 0);
                    itemOrderPerCLabel.Name = "itemOrderPerCLabel";
                    itemOrderPerCLabel.Size = new Size(50, 17);
                    itemOrderPerCLabel.TabIndex = 3;
                    itemOrderPerCLabel.Text = orderPerCustomer;
                    // 
                    // itemTime
                    // 
                    itemTime.AutoSize = true;
                    itemTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    itemTime.ForeColor = Color.Black;
                    itemTime.Location = new Point(453, itemNameLabelLocation);
                    itemTime.Margin = new Padding(100, 15, 3, 0);
                    itemTime.Name = "itemTime";
                    itemTime.Size = new Size(50, 17);
                    itemTime.TabIndex = 4;
                    itemTime.Text = time;


                    panelContainingOrderInfo.ResumeLayout(false);
                    panelContainingOrderInfo.PerformLayout();
                    panelContainingOrderInfo.SuspendLayout();
                    ((System.ComponentModel.ISupportInitialize)itemPictureBox).EndInit();
                    topOrderPanel.Controls.Add(countForOrders);
                    topOrderPanel.Controls.Add(panelContainingOrderInfo);
                    panelContainingOrderInfoLocation += 60;
                    itemPictureBoxLocation += 70;
                    itemNameLabelLocation += 70;
                    countForOrdersLocation += 70;
                }



            }


        }
        private object ExecuteScalarQuery(string query, SqlConnection connection)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                return command.ExecuteScalar();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminPicturebox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                adminPicturebox.Image = Image.FromFile(filePath);
            }
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            this.scrollableMenu.Hide();
            this.manageCustomerPanel.manageCPanel.Hide();
            this.manageOrdersPanel.panel.Hide();
            this.feedbackResponse.scrollableMenu.Hide();
            this.newItemPanel.panel.Show();
            this.Controls.Add(newItemPanel.panel);
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            this.scrollableMenu.Show();

        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
            this.scrollableMenu.Hide();
            this.manageOrdersPanel.panel.Hide();
            this.newItemPanel.panel.Hide();
            this.feedbackResponse.scrollableMenu.Hide();
            this.manageCustomerPanel.manageCPanel.Show();
            this.Controls.Add(manageCustomerPanel.manageCPanel);
          
        }

        private void feedbacksBtn_Click(object sender, EventArgs e)
        {
            this.scrollableMenu.Hide();
            this.manageOrdersPanel.panel.Hide();
            this.newItemPanel.panel.Hide();
            this.manageCustomerPanel.manageCPanel.Hide();
            this.feedbackResponse.scrollableMenu.Show();
            this.Controls.Add(feedbackResponse.scrollableMenu);
        }

        private void manageOrders_Click(object sender, EventArgs e)
        {
            this.scrollableMenu.Hide();
            this.newItemPanel.panel.Hide();
            this.manageCustomerPanel.manageCPanel.Hide();
            this.feedbackResponse.scrollableMenu.Hide();
            this.manageOrdersPanel.panel.Show();
            this.Controls.Add(manageOrdersPanel.panel);
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }

        /*  private void cutomersBtn_Click(object sender, EventArgs e)
          {
              this.scrollableMenu.Hide();
              this.Controls.Add(manageCustomerPanel.manageCPanel);
              manageCustomerPanel.manageCPanel.Show();
              menuOptions.panel.Hide();
          }

          private void logoutBtn_Click(object sender, EventArgs e)
          {
              this.Controls.Clear();
              this.Hide();
              loginForm.Show();
          }

          private void menusBtn_Click(object sender, EventArgs e)
          {



              *//* this.scrollableMenu.Hide();
              menuOptions.pictureBox1.BringToFront();*/
        /* this.scrollableMenu.Hide();
         menuOptions.panel.Show();
         Controls.Add(menuOptions.panel);
         manageCustomerPanel.manageCPanel.Hide();*//*
    }

    private void dashboardBtn_Click(object sender, EventArgs e)
    {
        this.scrollableMenu.Show();

    }
*/

    }
}
