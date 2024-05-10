namespace CafeManagementSystem
{
    partial class Add_new_item
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_new_item));
            panel = new Panel();
            panelContainingAddNewItem = new Panel();
            selectCategory = new ComboBox();
            categoryLabel = new Label();
            addNewItemLabel = new Label();
            addItemBtn = new Button();
            itemImageBox = new PictureBox();
            priceTextArea = new TextBox();
            itemPriceLabel = new Label();
            nameTextArea = new TextBox();
            itemImageLabel = new Label();
            itemNameLabel = new Label();
            label13 = new Label();
            label9 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            panel.SuspendLayout();
            panelContainingAddNewItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemImageBox).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.AutoScroll = true;
            panel.BackColor = Color.FromArgb(224, 224, 224);
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.Controls.Add(panelContainingAddNewItem);
            panel.Controls.Add(label13);
            panel.Controls.Add(label9);
            panel.Controls.Add(label12);
            panel.Controls.Add(label11);
            panel.Controls.Add(label10);
            panel.Controls.Add(label8);
            panel.Controls.Add(label7);
            panel.Controls.Add(label6);
            panel.Controls.Add(label5);
            panel.Controls.Add(label4);
            panel.Controls.Add(comboBox1);
            panel.Controls.Add(textBox1);
            panel.Controls.Add(progressBar1);
            panel.Controls.Add(label1);
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
            panelContainingAddNewItem.Controls.Add(addNewItemLabel);
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
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryLabel.ForeColor = Color.Black;
            categoryLabel.Location = new Point(28, 184);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(72, 19);
            categoryLabel.TabIndex = 34;
            categoryLabel.Text = "Category";
            // 
            // addNewItemLabel
            // 
            addNewItemLabel.AutoSize = true;
            addNewItemLabel.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addNewItemLabel.ForeColor = Color.Black;
            addNewItemLabel.Location = new Point(103, 19);
            addNewItemLabel.Name = "addNewItemLabel";
            addNewItemLabel.Size = new Size(133, 23);
            addNewItemLabel.TabIndex = 23;
            addNewItemLabel.Text = "Add new item";
            // 
            // addItemBtn
            // 
            addItemBtn.BackColor = Color.Green;
            addItemBtn.FlatStyle = FlatStyle.Flat;
            addItemBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addItemBtn.ForeColor = Color.Black;
            addItemBtn.Location = new Point(103, 394);
            addItemBtn.Name = "addItemBtn";
            addItemBtn.Size = new Size(133, 36);
            addItemBtn.TabIndex = 33;
            addItemBtn.Text = "Add item";
            addItemBtn.UseVisualStyleBackColor = false;
            // 
            // itemImageBox
            // 
            itemImageBox.BackColor = Color.Silver;
            itemImageBox.Image = (Image)resources.GetObject("itemImageBox.Image");
            itemImageBox.Location = new Point(90, 273);
            itemImageBox.Name = "itemImageBox";
            itemImageBox.Size = new Size(161, 103);
            itemImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            itemImageBox.TabIndex = 32;
            itemImageBox.TabStop = false;
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
            itemPriceLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            itemImageLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            itemNameLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemNameLabel.ForeColor = Color.Black;
            itemNameLabel.Location = new Point(28, 56);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(51, 19);
            itemNameLabel.TabIndex = 27;
            itemNameLabel.Text = "Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(519, -223);
            label13.Name = "label13";
            label13.Size = new Size(123, 19);
            label13.TabIndex = 18;
            label13.Text = "Customer Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(256, -223);
            label9.Name = "label9";
            label9.Size = new Size(51, 19);
            label9.TabIndex = 14;
            label9.Text = "Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(156, -223);
            label12.Name = "label12";
            label12.Size = new Size(58, 19);
            label12.TabIndex = 17;
            label12.Text = "Picture";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(348, -223);
            label11.Name = "label11";
            label11.Size = new Size(43, 19);
            label11.TabIndex = 16;
            label11.Text = "Price";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(438, -223);
            label10.Name = "label10";
            label10.Size = new Size(53, 19);
            label10.TabIndex = 15;
            label10.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(55, -223);
            label8.Name = "label8";
            label8.Size = new Size(62, 19);
            label8.TabIndex = 13;
            label8.Text = "Item ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(38, -438);
            label7.Name = "label7";
            label7.Size = new Size(93, 28);
            label7.TabIndex = 12;
            label7.Text = "MENUS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(55, -398);
            label6.Name = "label6";
            label6.Size = new Size(70, 23);
            label6.TabIndex = 11;
            label6.Text = "Orders";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(521, -316);
            label5.Name = "label5";
            label5.Size = new Size(39, 16);
            label5.TabIndex = 9;
            label5.Text = "Filter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(348, -278);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 8;
            label4.Text = "Progress";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(566, -319);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(88, 23);
            comboBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(429, -348);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search orders";
            textBox1.Size = new Size(225, 23);
            textBox1.TabIndex = 6;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(429, -278);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(225, 23);
            progressBar1.TabIndex = 4;
            progressBar1.Value = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(38, -497);
            label1.Name = "label1";
            label1.Size = new Size(74, 24);
            label1.TabIndex = 3;
            label1.Text = "Orders";
            // 
            // Add_new_item
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.Black;
            ClientSize = new Size(828, 535);
            Controls.Add(panel);
            ForeColor = Color.BlanchedAlmond;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Add_new_item";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            panelContainingAddNewItem.ResumeLayout(false);
            panelContainingAddNewItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)itemImageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public Panel panel;
        private Label label1;
        private ProgressBar progressBar1;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label13;
        private Label label9;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label addNewItemLabel;
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
    }
}