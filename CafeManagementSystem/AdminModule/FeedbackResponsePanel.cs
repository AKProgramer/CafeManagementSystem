namespace CafeManagementSystem.AdminModule
{
    internal class FeedbackResponsePanel
    {
        public Panel scrollableMenu;
        private Label label7;
        private TextBox textBox1;
        private Label label13;
        private Label label1;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        public FeedbackResponsePanel()
        {
           
            scrollableMenu = new Panel();
            label13 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
           
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
           
            scrollableMenu.SuspendLayout();
            // 
            // scrollableMenu
            // 
            scrollableMenu.AutoScroll = true;
            scrollableMenu.BackColor = Color.FromArgb(224, 224, 224);
            scrollableMenu.BorderStyle = BorderStyle.Fixed3D;
            scrollableMenu.Controls.Add(textBox2);
            scrollableMenu.Controls.Add(label5);
            scrollableMenu.Controls.Add(label4);
            scrollableMenu.Controls.Add(label1);
            scrollableMenu.Controls.Add(label13);
            scrollableMenu.Controls.Add(label7);
            scrollableMenu.Controls.Add(textBox1);
            scrollableMenu.Location = new Point(119, 54);
            scrollableMenu.Name = "scrollableMenu";
            scrollableMenu.Size = new Size(710, 498);
            scrollableMenu.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(60, 101);
            label13.Name = "label13";
            label13.Size = new Size(131, 19);
            label13.TabIndex = 18;
            label13.Text = "Customer Name :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(243, 9);
            label7.Name = "label7";
            label7.Size = new Size(175, 28);
            label7.TabIndex = 12;
            label7.Text = "User Feedbacks";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 58);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search by customer name";
            textBox1.Size = new Size(225, 23);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(207, 101);
            label1.Name = "label1";
            label1.Size = new Size(78, 19);
            label1.TabIndex = 26;
            label1.Text = "Ali Hassan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(148, 135);
            label4.Name = "label4";
            label4.Size = new Size(156, 19);
            label4.TabIndex = 27;
            label4.Text = "I didnot like the UI of customer side";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(60, 135);
            label5.Name = "label5";
            label5.Size = new Size(82, 19);
            label5.TabIndex = 28;
            label5.Text = "Feedback :";
            // 
            // textBox2
            // 
            textBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(60, 172);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Give Response to your customers feedback";
            textBox2.Size = new Size(600, 113);
            textBox2.TabIndex = 29;
           
           
            scrollableMenu.ResumeLayout(false);
            scrollableMenu.PerformLayout();
           
       
       
        }


    }
}
