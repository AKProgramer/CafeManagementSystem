namespace CafeManagementSystem
{
    partial class Customers
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
            MenuPanel = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnLogout = new Button();
            pnlNav = new Panel();
            btnPayment = new Button();
            btnOrder = new Button();
            btnMenu = new Button();
            exitButton = new Button();
            manageCPanel = new Panel();
            cancelBtn = new Button();
            deleteBtn = new Button();
            scrollablePanel = new Panel();
            panelContainingCustomerInfo = new Panel();
            statusLabel = new Label();
            passwordLabel = new Label();
            itemIDLabel = new Label();
            usernameLabel = new Label();
            emailLabel = new Label();
            filter = new ComboBox();
            label8 = new Label();
            label13 = new Label();
            label9 = new Label();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            label5 = new Label();
            searchbar = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            MenuPanel.SuspendLayout();
            manageCPanel.SuspendLayout();
            scrollablePanel.SuspendLayout();
            panelContainingCustomerInfo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            cancelBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cancelBtn.Location = new Point(385, 419);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(125, 39);
            cancelBtn.TabIndex = 27;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
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
            deleteBtn.Click += deleteBtn_Click;
            // 
            // scrollablePanel
            // 
            scrollablePanel.AutoScroll = true;
            scrollablePanel.Controls.Add(panelContainingCustomerInfo);
            scrollablePanel.Location = new Point(36, 165);
            scrollablePanel.Name = "scrollablePanel";
            scrollablePanel.Size = new Size(629, 237);
            scrollablePanel.TabIndex = 25;
            // 
            // panelContainingCustomerInfo
            // 
            panelContainingCustomerInfo.BackColor = Color.White;
            panelContainingCustomerInfo.Controls.Add(statusLabel);
            panelContainingCustomerInfo.Controls.Add(passwordLabel);
            panelContainingCustomerInfo.Controls.Add(itemIDLabel);
            panelContainingCustomerInfo.Controls.Add(usernameLabel);
            panelContainingCustomerInfo.Controls.Add(emailLabel);
            panelContainingCustomerInfo.Location = new Point(6, 12);
            panelContainingCustomerInfo.Name = "panelContainingCustomerInfo";
            panelContainingCustomerInfo.Size = new Size(603, 65);
            panelContainingCustomerInfo.TabIndex = 23;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = Color.White;
            statusLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusLabel.ForeColor = Color.Green;
            statusLabel.Location = new Point(537, 14);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(51, 19);
            statusLabel.TabIndex = 21;
            statusLabel.Text = "Name";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.Black;
            passwordLabel.Location = new Point(398, 14);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(51, 19);
            passwordLabel.TabIndex = 22;
            passwordLabel.Text = "Name";
            // 
            // itemIDLabel
            // 
            itemIDLabel.AutoSize = true;
            itemIDLabel.BackColor = Color.DimGray;
            itemIDLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemIDLabel.ForeColor = Color.Black;
            itemIDLabel.Location = new Point(12, 14);
            itemIDLabel.Name = "itemIDLabel";
            itemIDLabel.Size = new Size(18, 19);
            itemIDLabel.TabIndex = 19;
            itemIDLabel.Text = "1";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.Black;
            usernameLabel.Location = new Point(85, 14);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(51, 19);
            usernameLabel.TabIndex = 20;
            usernameLabel.Text = "Name";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = Color.Black;
            emailLabel.Location = new Point(188, 14);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(51, 19);
            emailLabel.TabIndex = 19;
            emailLabel.Text = "Name";
            // 
            // filter
            // 
            filter.FormattingEnabled = true;
            filter.Location = new Point(577, 84);
            filter.Name = "filter";
            filter.Size = new Size(88, 23);
            filter.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            label13.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            label9.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            label11.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            label10.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(577, 143);
            label10.Name = "label10";
            label10.Size = new Size(40, 19);
            label10.TabIndex = 15;
            label10.Text = "Role";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            label5.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(exitButton);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(828, 57);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(664, 27);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(718, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(664, 12);
            label2.Name = "label2";
            label2.Size = new Size(48, 16);
            label2.TabIndex = 4;
            label2.Text = "Mr Ali ";
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.Black;
            ClientSize = new Size(828, 535);
            Controls.Add(panel1);
            Controls.Add(manageCPanel);
            Controls.Add(MenuPanel);
            ForeColor = Color.BlanchedAlmond;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MenuPanel.ResumeLayout(false);
            manageCPanel.ResumeLayout(false);
            manageCPanel.PerformLayout();
            scrollablePanel.ResumeLayout(false);
            panelContainingCustomerInfo.ResumeLayout(false);
            panelContainingCustomerInfo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel manageCPanel;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private ComboBox filter;
        private TextBox searchbar;
        private Label label5;
        private Label label7;
        private Label label13;
        private Label label9;
        private Label label11;
        private Label label10;
        private Label label8;
        private Panel scrollablePanel;
        private Panel panelContainingCustomerInfo;
        private Label statusLabel;
        private Label passwordLabel;
        private Label itemIDLabel;
        private Label usernameLabel;
        private Label emailLabel;
        private Button deleteBtn;
        private Button cancelBtn;
    }
}