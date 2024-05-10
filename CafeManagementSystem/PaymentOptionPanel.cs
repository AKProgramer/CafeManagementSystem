using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CafeManagementSystem
{
    internal class PaymentOptionPanel
    {
        private PaymentPanel paymentPanel;
        public Panel panelContainingPayOptionButtons;
        private Label label1;
        private Button payByCardBtn;
        private Button payByCashBtn;

        public PaymentOptionPanel()
        {
            
            panelContainingPayOptionButtons = new Panel();
            label1 = new Label();
            payByCardBtn = new Button();
            payByCashBtn = new Button();
          
            panelContainingPayOptionButtons.SuspendLayout();
            paymentPanel = new PaymentPanel();


            
            // 
            // panelContainingPayOptionButtons
            // 
            panelContainingPayOptionButtons.AutoScroll = true;
            panelContainingPayOptionButtons.BackColor = Color.FromArgb(64, 64, 64);
            panelContainingPayOptionButtons.Controls.Add(payByCashBtn);
            panelContainingPayOptionButtons.Controls.Add(label1);
            panelContainingPayOptionButtons.Controls.Add(payByCardBtn);
            panelContainingPayOptionButtons.Location = new Point(119, 102);
            panelContainingPayOptionButtons.Name = "panelContainingPayOptionButtons";
            panelContainingPayOptionButtons.Size = new Size(708, 432);
            panelContainingPayOptionButtons.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new System.Drawing.Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(150, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 9;
            label1.Text = "Payment";
            // 
            // payByCardBtn
            // 
            payByCardBtn.BackColor = Color.Chocolate;
            payByCardBtn.FlatStyle = FlatStyle.Popup;
            payByCardBtn.Font = new System.Drawing.Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payByCardBtn.ForeColor = Color.Black;
            payByCardBtn.Location = new Point(100, 30);
            payByCardBtn.Name = "payByCardBtn";
            payByCardBtn.Size = new Size(271, 123);
            payByCardBtn.TabIndex = 8;
            payByCardBtn.Text = "Payment By Card";
            payByCardBtn.UseVisualStyleBackColor = false;
            payByCardBtn.Click += payByCardBtn_Click;
            // 
            // payByCashBtn
            // 
            payByCashBtn.BackColor = Color.Chocolate;
            payByCashBtn.FlatStyle = FlatStyle.Popup;
            payByCashBtn.Font = new System.Drawing.Font("Segoe UI", 18F, FontStyle.Bold);
            payByCashBtn.ForeColor = Color.Black;
            payByCashBtn.Location = new Point(100, 200);
            payByCashBtn.Name = "payByCashBtn";
            payByCashBtn.Size = new Size(271, 123);
            payByCashBtn.TabIndex = 10;
            payByCashBtn.Text = "Payment By Cash";
            payByCashBtn.UseVisualStyleBackColor = false;
        }
        public void payByCardBtn_Click(object sender, EventArgs e)
        {
            // this.Hide();
            this.panelContainingPayOptionButtons.Controls.Clear();
            this.panelContainingPayOptionButtons.Controls.Add(paymentPanel.scrollableMenu);
          
           
        }

    }
}
