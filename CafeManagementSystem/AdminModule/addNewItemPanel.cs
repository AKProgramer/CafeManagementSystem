using System.Data.SqlClient;
namespace CafeManagementSystem.AdminModule
{
    internal class AddNewItemPanel

    {
        private const string connectionString = "Data Source=CODING-0\\SQLEXPRESS;Initial Catalog=database_project;Integrated Security=True";
        public Panel panel { get; set; }
        private Label label20;
        private Label itemNameLabel;
        private Label itemImageLabel;
        private Label itemPriceLabel;
        private Panel panelContainingAddNewItem;
        private TextBox nameTextArea;
        private PictureBox itemImageBox;
        private TextBox priceTextArea;
        private Button addItemBtn;
        private Label categoryLabel;
        private ComboBox selectCategory;
        private string filePath;
        public AddNewItemPanel()
        {
            filePath = "";
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_new_item));
            panel = new Panel();
            panelContainingAddNewItem = new Panel();
            selectCategory = new ComboBox();
            categoryLabel = new Label();
            label20 = new Label();
            addItemBtn = new Button();
            itemImageBox = new PictureBox();
            priceTextArea = new TextBox();
            itemPriceLabel = new Label();
            nameTextArea = new TextBox();
            itemImageLabel = new Label();
            itemNameLabel = new Label();
            panel.SuspendLayout();
            panelContainingAddNewItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemImageBox).BeginInit();

            // 
            // panel
            // 
            panel.AutoScroll = true;
            panel.BackColor = Color.FromArgb(224, 224, 224);
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.Controls.Add(panelContainingAddNewItem);
            panel.Location = new Point(119, 54);
            panel.Name = "panel";
            panel.Size = new Size(710, 498);
            panel.TabIndex = 6;
            // 
            // panelContainingAddNewItem
            // 
            panelContainingAddNewItem.BackColor = Color.White;
            panelContainingAddNewItem.Controls.Add(selectCategory);
            panelContainingAddNewItem.Controls.Add(categoryLabel);
            panelContainingAddNewItem.Controls.Add(label20);
            panelContainingAddNewItem.Controls.Add(addItemBtn);
            panelContainingAddNewItem.Controls.Add(itemImageBox);
            panelContainingAddNewItem.Controls.Add(priceTextArea);
            panelContainingAddNewItem.Controls.Add(itemPriceLabel);
            panelContainingAddNewItem.Controls.Add(nameTextArea);
            panelContainingAddNewItem.Controls.Add(itemImageLabel);
            panelContainingAddNewItem.Controls.Add(itemNameLabel);
            panelContainingAddNewItem.Location = new Point(179, 19);
            panelContainingAddNewItem.Name = "panelContainingAddNewItem";
            panelContainingAddNewItem.Size = new Size(338, 448);
            panelContainingAddNewItem.TabIndex = 20;

            // 
            // selectCategory
            // 
            selectCategory.FormattingEnabled = true;
            selectCategory.Location = new Point(33, 206);
            selectCategory.Name = "selectCategory";
            selectCategory.Size = new Size(270, 23);
            selectCategory.TabIndex = 36;
            selectCategory.Items.Add("Breakfast");
            selectCategory.Items.Add("Lunch");

            // Set breakfast as the default category
            selectCategory.SelectedIndex = 0;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryLabel.ForeColor = Color.Black;
            categoryLabel.Location = new Point(28, 184);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(72, 19);
            categoryLabel.TabIndex = 34;
            categoryLabel.Text = "Category";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(103, 19);
            label20.Name = "label20";
            label20.Size = new Size(133, 23);
            label20.TabIndex = 23;
            label20.Text = "Add new item";
            // 
            // addItemBtn
            // 
            addItemBtn.BackColor = Color.Green;
            addItemBtn.FlatStyle = FlatStyle.Flat;
            addItemBtn.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addItemBtn.ForeColor = Color.Black;
            addItemBtn.Location = new Point(103, 394);
            addItemBtn.Name = "addItemBtn";
            addItemBtn.Size = new Size(133, 36);
            addItemBtn.TabIndex = 33;
            addItemBtn.Text = "Add item";
            addItemBtn.UseVisualStyleBackColor = false;
            addItemBtn.Click += AddItemBtn_Click;
            // 
            // itemImageBox
            // 
            itemImageBox.BackColor = Color.Silver;
            itemImageBox.Image = (System.Drawing.Image)resources.GetObject("itemImageBox.Image");
            itemImageBox.Location = new Point(90, 273);
            itemImageBox.Name = "itemImageBox";
            itemImageBox.Size = new Size(161, 103);
            itemImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            itemImageBox.TabIndex = 32;
            itemImageBox.TabStop = false;
            itemImageBox.Click += ItemImageBox_Click;
            // 
            // priceTextArea
            // 
            priceTextArea.Location = new Point(33, 141);
            priceTextArea.Name = "priceTextArea";
            priceTextArea.Size = new Size(270, 23);
            priceTextArea.TabIndex = 31;
            // 
            // itemPriceLabel
            // 
            itemPriceLabel.AutoSize = true;
            itemPriceLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemPriceLabel.ForeColor = Color.Black;
            itemPriceLabel.Location = new Point(28, 118);
            itemPriceLabel.Name = "itemPriceLabel";
            itemPriceLabel.Size = new Size(43, 19);
            itemPriceLabel.TabIndex = 28;
            itemPriceLabel.Text = "Price";
            // 
            // nameTextArea
            // 
            nameTextArea.Location = new Point(33, 78);
            nameTextArea.Name = "nameTextArea";
            nameTextArea.Size = new Size(270, 23);
            nameTextArea.TabIndex = 30;
            // 
            // itemImageLabel
            // 
            itemImageLabel.AutoSize = true;
            itemImageLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemImageLabel.ForeColor = Color.Black;
            itemImageLabel.Location = new Point(33, 242);
            itemImageLabel.Name = "itemImageLabel";
            itemImageLabel.Size = new Size(53, 19);
            itemImageLabel.TabIndex = 29;
            itemImageLabel.Text = "Image";
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemNameLabel.ForeColor = Color.Black;
            itemNameLabel.Location = new Point(28, 56);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(51, 19);
            itemNameLabel.TabIndex = 27;
            itemNameLabel.Text = "Name";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            panelContainingAddNewItem.ResumeLayout(false);
            panelContainingAddNewItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)itemImageBox).EndInit();

        }
        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            // Check if any of the fields are empty
            if (string.IsNullOrEmpty(itemNameLabel.Text) ||
                string.IsNullOrEmpty(itemPriceLabel.Text)
                || string.IsNullOrEmpty(filePath)
               
                )
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert data into the table
            string name = nameTextArea.Text;
            string price = priceTextArea.Text;
            string imageUrl = filePath;
            string category = (selectCategory.SelectedItem.ToString());

            // Insert data into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Item (Name, Price, ImageURL, Time) VALUES (@Name, @Price, @ImageURL, @Time)";
                
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@ImageURL", imageUrl);
                command.Parameters.AddWithValue("@Time", category);
                MessageBox.Show(price.ToString());

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Optionally, clear the textboxes after successful insertion
                        itemNameLabel.Text = "";
                        itemPriceLabel.Text = "";


                    }
                    else
                    {
                        MessageBox.Show("Failed to add item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ItemImageBox_Click(object? sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                this.filePath = filePath;
                itemImageBox.Image = System.Drawing.Image.FromFile(filePath);
            }
        }
    }
}