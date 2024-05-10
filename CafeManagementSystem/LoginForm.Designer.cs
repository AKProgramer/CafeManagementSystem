namespace CafeManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            exitButton = new Button();
            loginPanel = new Panel();
            signupButton = new Button();
            loginButton = new Button();
            passwordTextarea = new TextBox();
            passwordLabel = new Label();
            usernameTextarea = new TextBox();
            usernameLabel = new Label();
            messageLabel = new Label();
            pictureBox1 = new PictureBox();
            loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.BackColor = SystemColors.ControlDark;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.ForeColor = Color.Black;
            exitButton.Location = new Point(760, 12);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(25, 25);
            exitButton.TabIndex = 10;
            exitButton.Text = "X";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(signupButton);
            loginPanel.Controls.Add(loginButton);
            loginPanel.Controls.Add(passwordTextarea);
            loginPanel.Controls.Add(passwordLabel);
            loginPanel.Controls.Add(usernameTextarea);
            loginPanel.Controls.Add(usernameLabel);
            loginPanel.Controls.Add(messageLabel);
            loginPanel.Location = new Point(204, 23);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(362, 486);
            loginPanel.TabIndex = 11;
            // 
            // signupButton
            // 
            signupButton.BackColor = SystemColors.ControlDark;
            signupButton.FlatStyle = FlatStyle.Flat;
            signupButton.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupButton.Location = new Point(93, 360);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(157, 32);
            signupButton.TabIndex = 18;
            signupButton.Text = "Signup";
            signupButton.UseVisualStyleBackColor = false;
            signupButton.Click += signupButton_Click;
            signupButton.MouseLeave += loginMouseLeave;
            // 
            // loginButton
            // 
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.Location = new Point(93, 313);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(157, 32);
            loginButton.TabIndex = 15;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            loginButton.MouseEnter += loginMouseEnter;
            // 
            // passwordTextarea
            // 
            passwordTextarea.Location = new Point(66, 214);
            passwordTextarea.Name = "passwordTextarea";
            passwordTextarea.Size = new Size(223, 23);
            passwordTextarea.TabIndex = 14;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(66, 193);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(72, 18);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Password";
            // 
            // usernameTextarea
            // 
            usernameTextarea.Location = new Point(66, 135);
            usernameTextarea.Name = "usernameTextarea";
            usernameTextarea.Size = new Size(223, 23);
            usernameTextarea.TabIndex = 12;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(66, 114);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(72, 18);
            usernameLabel.TabIndex = 11;
            usernameLabel.Text = "Username";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(121, 52);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(120, 18);
            messageLabel.TabIndex = 10;
            messageLabel.Text = "Ready to login";
            messageLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(797, 531);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 531);
            Controls.Add(loginPanel);
            Controls.Add(exitButton);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button exitButton;
        public Panel loginPanel;
        private Button signupButton;
        private Button loginButton;
        private TextBox passwordTextarea;
        private Label passwordLabel;
        private TextBox usernameTextarea;
        private Label usernameLabel;
        private Label messageLabel;
        private PictureBox pictureBox1;
    }
}