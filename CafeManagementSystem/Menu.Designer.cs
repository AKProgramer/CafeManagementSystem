namespace CafeManagementSystem
{
    partial class Menu
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
            itemCount = new Label();
            btnLogout = new Button();
            pnlNav = new Panel();
            btnPayment = new Button();
            btnOrder = new Button();
            btnMenu = new Button();
            exitButton = new Button();
            scrollableMenu = new Panel();
            lunchFlowlayout = new FlowLayoutPanel();
            label1 = new Label();
            breakfastFlowlayout = new FlowLayoutPanel();
            breakfastLabel = new Label();
            panel1 = new Panel();
            label2 = new Label();
            MenuPanel.SuspendLayout();
            scrollableMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.Black;
            MenuPanel.Controls.Add(itemCount);
            MenuPanel.Controls.Add(btnLogout);
            MenuPanel.Controls.Add(pnlNav);
            MenuPanel.Controls.Add(btnPayment);
            MenuPanel.Controls.Add(btnOrder);
            MenuPanel.Controls.Add(btnMenu);
            MenuPanel.Location = new Point(1, 48);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(120, 489);
            MenuPanel.TabIndex = 0;
            // 
            // itemCount
            // 
            itemCount.AutoSize = true;
            itemCount.BackColor = Color.Red;
            itemCount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemCount.ForeColor = Color.Transparent;
            itemCount.Location = new Point(97, 57);
            itemCount.Name = "itemCount";
            itemCount.Size = new Size(15, 17);
            itemCount.TabIndex = 0;
            itemCount.Text = "0";
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold);
            btnLogout.ForeColor = Color.Chocolate;
            btnLogout.Location = new Point(0, 447);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(120, 42);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            btnLogout.Leave += btnLogout_Leave;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.Chocolate;
            pnlNav.Location = new Point(0, 160);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 100);
            pnlNav.TabIndex = 3;
            // 
            // btnPayment
            // 
            btnPayment.Dock = DockStyle.Top;
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold);
            btnPayment.ForeColor = Color.Chocolate;
            btnPayment.Location = new Point(0, 84);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(120, 42);
            btnPayment.TabIndex = 3;
            btnPayment.Text = "Feedback";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            btnPayment.Leave += btnPayment_Leave;
            // 
            // btnOrder
            // 
            btnOrder.Dock = DockStyle.Top;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold);
            btnOrder.ForeColor = Color.Chocolate;
            btnOrder.Location = new Point(0, 42);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(120, 42);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            btnOrder.Leave += btnOrder_Leave;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.Chocolate;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(120, 42);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            btnMenu.Leave += btnMenu_Leave;
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
            exitButton.Click += exitButton_Click;
            // 
            // scrollableMenu
            // 
            scrollableMenu.AutoScroll = true;
            scrollableMenu.BackColor = Color.FromArgb(64, 64, 64);
            scrollableMenu.Controls.Add(lunchFlowlayout);
            scrollableMenu.Controls.Add(label1);
            scrollableMenu.Controls.Add(breakfastFlowlayout);
            scrollableMenu.Controls.Add(breakfastLabel);
            scrollableMenu.Location = new Point(119, 45);
            scrollableMenu.Name = "scrollableMenu";
            scrollableMenu.Size = new Size(710, 492);
            scrollableMenu.TabIndex = 6;
            // 
            // lunchFlowlayout
            // 
            lunchFlowlayout.AutoScroll = true;
            lunchFlowlayout.Location = new Point(8, 321);
            lunchFlowlayout.Name = "lunchFlowlayout";
            lunchFlowlayout.Size = new Size(677, 206);
            lunchFlowlayout.TabIndex = 2;
            lunchFlowlayout.WrapContents = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(20, 286);
            label1.Name = "label1";
            label1.Size = new Size(68, 26);
            label1.TabIndex = 2;
            label1.Text = "Lunch";
            // 
            // breakfastFlowlayout
            // 
            breakfastFlowlayout.AutoScroll = true;
            breakfastFlowlayout.BackColor = Color.Transparent;
            breakfastFlowlayout.Location = new Point(8, 62);
            breakfastFlowlayout.Name = "breakfastFlowlayout";
            breakfastFlowlayout.Size = new Size(677, 206);
            breakfastFlowlayout.TabIndex = 1;
            breakfastFlowlayout.WrapContents = false;
            // 
            // breakfastLabel
            // 
            breakfastLabel.AutoSize = true;
            breakfastLabel.BackColor = Color.FromArgb(64, 64, 64);
            breakfastLabel.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            breakfastLabel.ForeColor = Color.Chocolate;
            breakfastLabel.Location = new Point(20, 16);
            breakfastLabel.Name = "breakfastLabel";
            breakfastLabel.Size = new Size(98, 26);
            breakfastLabel.TabIndex = 0;
            breakfastLabel.Text = "Breakfast";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Chocolate;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(exitButton);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(828, 57);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(231, 12);
            label2.Name = "label2";
            label2.Size = new Size(353, 30);
            label2.TabIndex = 4;
            label2.Text = "THE CAFE MANAGEMENT SYSTEM";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(828, 535);
            Controls.Add(panel1);
            Controls.Add(scrollableMenu);
            Controls.Add(MenuPanel);
            ForeColor = Color.BlanchedAlmond;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MenuPanel.ResumeLayout(false);
            MenuPanel.PerformLayout();
            scrollableMenu.ResumeLayout(false);
            scrollableMenu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel scrollableMenu;
        private FlowLayoutPanel breakfastFlowlayout;
        private Label breakfastLabel;
        private FlowLayoutPanel lunchFlowlayout;
        private Label label1;
        private Label itemCount;
        private Panel panel1;
        private Label label2;
    }
}
