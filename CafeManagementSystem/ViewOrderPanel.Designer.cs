namespace CafeManagementSystem
{
    partial class ViewOrderPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrderPanel));
            MenuPanel = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnLogout = new Button();
            pnlNav = new Panel();
            btnPayment = new Button();
            btnOrder = new Button();
            btnMenu = new Button();
            exitButton = new Button();
            panel = new Panel();
            cancleBtn = new Button();
            deleteBtn = new Button();
            scrollablePanel = new Panel();
            panel3 = new Panel();
            itemStatus = new Label();
            itemCustomer = new Label();
            itemID = new Label();
            itemPictureBox = new PictureBox();
            itemPrice = new Label();
            itemName = new Label();
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
            upperNavBar = new Panel();
            adminRoleLabel = new Label();
            adminPicture = new PictureBox();
            adminNameLabel = new Label();
            MenuPanel.SuspendLayout();
            panel.SuspendLayout();
            scrollablePanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemPictureBox).BeginInit();
            upperNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminPicture).BeginInit();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.Silver;
            MenuPanel.BorderStyle = BorderStyle.Fixed3D;
            MenuPanel.Controls.Add(button2);
            MenuPanel.Controls.Add(button1);
            MenuPanel.Controls.Add(btnLogout);
            MenuPanel.Controls.Add(pnlNav);
            MenuPanel.Controls.Add(btnPayment);
            MenuPanel.Controls.Add(btnOrder);
            MenuPanel.Controls.Add(btnMenu);
            MenuPanel.Location = new Point(1, 57);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(120, 480);
            MenuPanel.TabIndex = 0;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(0, 126);
            button2.Name = "button2";
            button2.Size = new Size(116, 42);
            button2.TabIndex = 6;
            button2.Text = "FEEDBACKS";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(0, 84);
            button1.Name = "button1";
            button1.Size = new Size(116, 42);
            button1.TabIndex = 5;
            button1.Text = "CUSTOMERS";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.System;
            btnLogout.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnLogout.ForeColor = Color.Black;
            btnLogout.Location = new Point(0, 434);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(116, 42);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.Black;
            pnlNav.Location = new Point(0, 160);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 100);
            pnlNav.TabIndex = 3;
            // 
            // btnPayment
            // 
            btnPayment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.System;
            btnPayment.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            btnPayment.ForeColor = Color.Black;
            btnPayment.Location = new Point(0, 84);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(116, 42);
            btnPayment.TabIndex = 3;
            btnPayment.Text = "CUSTOMERS";
            btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.Dock = DockStyle.Top;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.System;
            btnOrder.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrder.ForeColor = Color.Black;
            btnOrder.Location = new Point(0, 42);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(116, 42);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "MENUS";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.System;
            btnMenu.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.Black;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(116, 42);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "DASHBOARD";
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Black;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.ForeColor = Color.IndianRed;
            exitButton.Location = new Point(790, 12);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(25, 25);
            exitButton.TabIndex = 3;
            exitButton.Text = "X";
            exitButton.UseVisualStyleBackColor = false;
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
            cancleBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
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
            deleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
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
            scrollablePanel.Controls.Add(panel3);
            scrollablePanel.Location = new Point(36, 165);
            scrollablePanel.Name = "scrollablePanel";
            scrollablePanel.Size = new Size(629, 237);
            scrollablePanel.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(itemStatus);
            panel3.Controls.Add(itemCustomer);
            panel3.Controls.Add(itemID);
            panel3.Controls.Add(itemPictureBox);
            panel3.Controls.Add(itemPrice);
            panel3.Controls.Add(itemName);
            panel3.Location = new Point(6, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(603, 65);
            panel3.TabIndex = 23;
            // 
            // itemStatus
            // 
            itemStatus.AutoSize = true;
            itemStatus.BackColor = Color.White;
            itemStatus.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemStatus.ForeColor = Color.Green;
            itemStatus.Location = new Point(397, 14);
            itemStatus.Name = "itemStatus";
            itemStatus.Size = new Size(51, 19);
            itemStatus.TabIndex = 21;
            itemStatus.Text = "Name";
            // 
            // itemCustomer
            // 
            itemCustomer.AutoSize = true;
            itemCustomer.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemCustomer.ForeColor = Color.Black;
            itemCustomer.Location = new Point(480, 14);
            itemCustomer.Name = "itemCustomer";
            itemCustomer.Size = new Size(51, 19);
            itemCustomer.TabIndex = 22;
            itemCustomer.Text = "Name";
            // 
            // itemID
            // 
            itemID.AutoSize = true;
            itemID.BackColor = Color.DimGray;
            itemID.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemID.ForeColor = Color.Black;
            itemID.Location = new Point(18, 14);
            itemID.Name = "itemID";
            itemID.Size = new Size(18, 19);
            itemID.TabIndex = 19;
            itemID.Text = "1";
            // 
            // itemPictureBox
            // 
            itemPictureBox.Image = (Image)resources.GetObject("itemPictureBox.Image");
            itemPictureBox.Location = new Point(115, 3);
            itemPictureBox.Name = "itemPictureBox";
            itemPictureBox.Size = new Size(58, 46);
            itemPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            itemPictureBox.TabIndex = 0;
            itemPictureBox.TabStop = false;
            // 
            // itemPrice
            // 
            itemPrice.AutoSize = true;
            itemPrice.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemPrice.ForeColor = Color.Black;
            itemPrice.Location = new Point(307, 14);
            itemPrice.Name = "itemPrice";
            itemPrice.Size = new Size(51, 19);
            itemPrice.TabIndex = 20;
            itemPrice.Text = "Name";
            // 
            // itemName
            // 
            itemName.AutoSize = true;
            itemName.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemName.ForeColor = Color.Black;
            itemName.Location = new Point(215, 14);
            itemName.Name = "itemName";
            itemName.Size = new Size(51, 19);
            itemName.TabIndex = 19;
            itemName.Text = "Name";
            // 
            // selectFilterComboBox
            // 
            selectFilterComboBox.FormattingEnabled = true;
            selectFilterComboBox.Location = new Point(577, 84);
            selectFilterComboBox.Name = "selectFilterComboBox";
            selectFilterComboBox.Size = new Size(88, 23);
            selectFilterComboBox.TabIndex = 7;
            // 
            // itemIDLabel
            // 
            itemIDLabel.AutoSize = true;
            itemIDLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            itemCustomerNameLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            itemNameLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            itemPicBoxLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            itemPriceLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            itemStatusLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            manageOrdersLabel.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            filterLabel.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            progressLabel.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            // 
            // orderProgressBar
            // 
            orderProgressBar.Location = new Point(442, 16);
            orderProgressBar.Name = "orderProgressBar";
            orderProgressBar.Size = new Size(225, 23);
            orderProgressBar.TabIndex = 4;
            orderProgressBar.Value = 7;
            // 
            // upperNavBar
            // 
            upperNavBar.BackColor = Color.Snow;
            upperNavBar.BorderStyle = BorderStyle.Fixed3D;
            upperNavBar.Controls.Add(adminRoleLabel);
            upperNavBar.Controls.Add(adminPicture);
            upperNavBar.Controls.Add(adminNameLabel);
            upperNavBar.Controls.Add(exitButton);
            upperNavBar.Location = new Point(1, 0);
            upperNavBar.Name = "upperNavBar";
            upperNavBar.Size = new Size(828, 57);
            upperNavBar.TabIndex = 7;
            // 
            // adminRoleLabel
            // 
            adminRoleLabel.AutoSize = true;
            adminRoleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminRoleLabel.ForeColor = Color.DimGray;
            adminRoleLabel.Location = new Point(664, 27);
            adminRoleLabel.Name = "adminRoleLabel";
            adminRoleLabel.Size = new Size(43, 15);
            adminRoleLabel.TabIndex = 6;
            adminRoleLabel.Text = "Admin";
            // 
            // adminPicture
            // 
            adminPicture.Image = (Image)resources.GetObject("adminPicture.Image");
            adminPicture.Location = new Point(718, 10);
            adminPicture.Name = "adminPicture";
            adminPicture.Size = new Size(42, 34);
            adminPicture.SizeMode = PictureBoxSizeMode.Zoom;
            adminPicture.TabIndex = 5;
            adminPicture.TabStop = false;
            // 
            // adminNameLabel
            // 
            adminNameLabel.AutoSize = true;
            adminNameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminNameLabel.ForeColor = SystemColors.ActiveCaptionText;
            adminNameLabel.Location = new Point(664, 12);
            adminNameLabel.Name = "adminNameLabel";
            adminNameLabel.Size = new Size(48, 16);
            adminNameLabel.TabIndex = 4;
            adminNameLabel.Text = "Mr Ali ";
            // 
            // ViewOrderPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.Black;
            ClientSize = new Size(828, 535);
            Controls.Add(upperNavBar);
            Controls.Add(panel);
            Controls.Add(MenuPanel);
            ForeColor = Color.BlanchedAlmond;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrderPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MenuPanel.ResumeLayout(false);
            panel.ResumeLayout(false);
            panel.PerformLayout();
            scrollablePanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)itemPictureBox).EndInit();
            upperNavBar.ResumeLayout(false);
            upperNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)adminPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuPanel;

        private Button btnMenu;
        private Button btnPayment;
        private Button btnOrder;
        private Panel pnlNav;
        private Button btnLogout;
        private Button exitButton;
        private Panel panel;
        private Panel upperNavBar;
        private Label adminNameLabel;
        private Label adminRoleLabel;
        private PictureBox adminPicture;
        private Button button1;
        private Button button2;
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
        private Panel panel3;
        private Label itemStatus;
        private Label itemCustomer;
        private Label itemID;
        private PictureBox itemPictureBox;
        private Label itemPrice;
        private Label itemName;
        private Button deleteBtn;
        private Button cancleBtn;
    }
}