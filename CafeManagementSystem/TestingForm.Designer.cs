namespace CafeManagementSystem
{
    partial class TestingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestingForm));
            exitButton = new Button();
            signupPanel = new Panel();
            usernameTextarea = new TextBox();
            usernameLabel = new Label();
            signupButton = new Button();
            roleLabel = new Label();
            selectRoleDropdown = new ComboBox();
            passwordTextarea = new TextBox();
            passwordLabel = new Label();
            emailTextarea = new TextBox();
            emailLabel = new Label();
            messageLabel = new Label();
            pictureBox1 = new PictureBox();
            signupPanel.SuspendLayout();
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
            // 
            // signupPanel
            // 
            signupPanel.Controls.Add(usernameTextarea);
            signupPanel.Controls.Add(usernameLabel);
            signupPanel.Controls.Add(signupButton);
            signupPanel.Controls.Add(roleLabel);
            signupPanel.Controls.Add(selectRoleDropdown);
            signupPanel.Controls.Add(passwordTextarea);
            signupPanel.Controls.Add(passwordLabel);
            signupPanel.Controls.Add(emailTextarea);
            signupPanel.Controls.Add(emailLabel);
            signupPanel.Controls.Add(messageLabel);
            signupPanel.Location = new Point(204, 23);
            signupPanel.Name = "signupPanel";
            signupPanel.Size = new Size(362, 486);
            signupPanel.TabIndex = 11;
            // 
            // usernameTextarea
            // 
            usernameTextarea.Location = new Point(62, 177);
            usernameTextarea.Name = "usernameTextarea";
            usernameTextarea.PlaceholderText = "Enter username";
            usernameTextarea.Size = new Size(223, 23);
            usernameTextarea.TabIndex = 20;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(62, 156);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(72, 18);
            usernameLabel.TabIndex = 19;
            usernameLabel.Text = "Username";
            // 
            // signupButton
            // 
            signupButton.BackColor = SystemColors.ControlDark;
            signupButton.FlatStyle = FlatStyle.Flat;
            signupButton.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupButton.Location = new Point(88, 396);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(157, 32);
            signupButton.TabIndex = 18;
            signupButton.Text = "Signup";
            signupButton.UseVisualStyleBackColor = false;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roleLabel.Location = new Point(62, 305);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(40, 18);
            roleLabel.TabIndex = 17;
            roleLabel.Text = "Role";
            // 
            // selectRoleDropdown
            // 
            selectRoleDropdown.FormattingEnabled = true;
            selectRoleDropdown.Items.AddRange(new object[] { "User", "Admin", "Staff" });
            selectRoleDropdown.Location = new Point(62, 326);
            selectRoleDropdown.Name = "selectRoleDropdown";
            selectRoleDropdown.Size = new Size(223, 23);
            selectRoleDropdown.TabIndex = 16;
            // 
            // passwordTextarea
            // 
            passwordTextarea.Location = new Point(62, 251);
            passwordTextarea.Name = "passwordTextarea";
            passwordTextarea.PlaceholderText = "Enter password";
            passwordTextarea.Size = new Size(223, 23);
            passwordTextarea.TabIndex = 14;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(62, 230);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(72, 18);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Password";
            // 
            // emailTextarea
            // 
            emailTextarea.Location = new Point(62, 98);
            emailTextarea.Name = "emailTextarea";
            emailTextarea.PlaceholderText = "Enter your email";
            emailTextarea.Size = new Size(223, 23);
            emailTextarea.TabIndex = 12;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(62, 77);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(48, 18);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(104, 25);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(128, 18);
            messageLabel.TabIndex = 10;
            messageLabel.Text = "Ready to Signup";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(798, 530);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TestingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 531);
            Controls.Add(signupPanel);
            Controls.Add(exitButton);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TestingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            signupPanel.ResumeLayout(false);
            signupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button exitButton;
        private Panel signupPanel;
        private Button signupButton;
        private Label roleLabel;
        private ComboBox selectRoleDropdown;
        private TextBox passwordTextarea;
        private Label passwordLabel;
        private TextBox emailTextarea;
        private Label emailLabel;
        private Label messageLabel;
        private TextBox usernameTextarea;
        private Label usernameLabel;
        private PictureBox pictureBox1;
    }
}