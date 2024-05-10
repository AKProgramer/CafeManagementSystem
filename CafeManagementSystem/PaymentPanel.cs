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
    internal class PaymentPanel
    { 
        public Panel scrollableMenu;
        private CheckBox checkBox1;
        private RichTextBox richTextBox1;
        private Label label1;
        private Button button1;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        public PaymentPanel()
        {
            scrollableMenu = new Panel();
            richTextBox1 = new RichTextBox();
            checkBox1 = new CheckBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            button1 = new Button();
            label1 = new Label();
            scrollableMenu.SuspendLayout();
           
            // 
            // scrollableMenu
            // 
            scrollableMenu.AutoScroll = true;
            scrollableMenu.BackColor = Color.FromArgb(64, 64, 64);
            scrollableMenu.Controls.Add(label1);
            scrollableMenu.Controls.Add(button1);
            scrollableMenu.Controls.Add(richTextBox4);
            scrollableMenu.Controls.Add(richTextBox3);
            scrollableMenu.Controls.Add(richTextBox2);
            scrollableMenu.Controls.Add(richTextBox1);
            scrollableMenu.Controls.Add(checkBox1);
           
            scrollableMenu.Location = new Point(119, 45);
            scrollableMenu.Name = "scrollableMenu";
            scrollableMenu.Size = new Size(710, 492);
            scrollableMenu.TabIndex = 6;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(194, 87);
            richTextBox1.Multiline = false;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(278, 45);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(194, 244);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(194, 173);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(118, 45);
            richTextBox2.TabIndex = 5;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(354, 173);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(118, 45);
            richTextBox3.TabIndex = 6;
            richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(194, 284);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(278, 45);
            richTextBox4.TabIndex = 7;
            richTextBox4.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(194, 353);
            button1.Name = "button1";
            button1.Size = new Size(278, 49);
            button1.TabIndex = 8;
            button1.Text = "Pay $20.00";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new System.Drawing.Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(100, 10);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 9;
            label1.Text = "Payment";
        }

      
    }
}
