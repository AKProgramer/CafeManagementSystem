namespace CafeManagementSystem
{
    partial class PaymentForm
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
            pnlNav = new Panel();
            scrollableMenu = new Panel();
            payByCashBtn = new Button();
            label1 = new Label();
            payByCardBtn = new Button();
            MenuPanel.SuspendLayout();
            scrollableMenu.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.Black;
            MenuPanel.Controls.Add(pnlNav);
            MenuPanel.Location = new Point(1, 48);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(120, 489);
            MenuPanel.TabIndex = 0;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.Chocolate;
            pnlNav.Location = new Point(0, 160);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 100);
            pnlNav.TabIndex = 3;
            // 
            // scrollableMenu
            // 
            scrollableMenu.AutoScroll = true;
            scrollableMenu.BackColor = Color.FromArgb(64, 64, 64);
            scrollableMenu.Controls.Add(payByCashBtn);
            scrollableMenu.Controls.Add(label1);
            scrollableMenu.Controls.Add(payByCardBtn);
            scrollableMenu.Location = new Point(119, 48);
            scrollableMenu.Name = "scrollableMenu";
            scrollableMenu.Size = new Size(708, 486);
            scrollableMenu.TabIndex = 6;
            // 
            // payByCashBtn
            // 
            payByCashBtn.BackColor = Color.Chocolate;
            payByCashBtn.FlatStyle = FlatStyle.Popup;
            payByCashBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            payByCashBtn.ForeColor = Color.Black;
            payByCashBtn.Location = new Point(198, 246);
            payByCashBtn.Name = "payByCashBtn";
            payByCashBtn.Size = new Size(271, 123);
            payByCashBtn.TabIndex = 10;
            payByCashBtn.Text = "Payment By Cash";
            payByCashBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(267, 21);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 9;
            label1.Text = "Payment";
            // 
            // payByCardBtn
            // 
            payByCardBtn.BackColor = Color.Chocolate;
            payByCardBtn.FlatStyle = FlatStyle.Popup;
            payByCardBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payByCardBtn.ForeColor = Color.Black;
            payByCardBtn.Location = new Point(198, 76);
            payByCardBtn.Name = "payByCardBtn";
            payByCardBtn.Size = new Size(271, 123);
            payByCardBtn.TabIndex = 8;
            payByCardBtn.Text = "Payment By Card";
            payByCardBtn.UseVisualStyleBackColor = false;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(828, 535);
            Controls.Add(scrollableMenu);
            Controls.Add(MenuPanel);
            ForeColor = Color.BlanchedAlmond;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MenuPanel.ResumeLayout(false);
            scrollableMenu.ResumeLayout(false);
            scrollableMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuPanel;
        private Panel pnlNav;
        private Panel scrollableMenu;
        private Label label1;
        private Button payByCardBtn;
        private Button payByCashBtn;
    }
}