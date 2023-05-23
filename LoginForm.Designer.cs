namespace StationExam
{
    partial class LoginForm
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
            Login_lb = new Label();
            Password_lb = new Label();
            Login_btn = new Button();
            Login_tb = new TextBox();
            Password_tb = new TextBox();
            Exit_btn = new Button();
            LoginErr_lb = new Label();
            PasswordErr_lb = new Label();
            SuspendLayout();
            // 
            // Login_lb
            // 
            Login_lb.AutoSize = true;
            Login_lb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Login_lb.Location = new Point(602, 240);
            Login_lb.Name = "Login_lb";
            Login_lb.Size = new Size(52, 20);
            Login_lb.TabIndex = 0;
            Login_lb.Text = "Login:";
            // 
            // Password_lb
            // 
            Password_lb.AutoSize = true;
            Password_lb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Password_lb.Location = new Point(602, 273);
            Password_lb.Name = "Password_lb";
            Password_lb.Size = new Size(80, 20);
            Password_lb.TabIndex = 1;
            Password_lb.Text = "Password:";
            // 
            // Login_btn
            // 
            Login_btn.Location = new Point(719, 318);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(94, 29);
            Login_btn.TabIndex = 2;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = true;
            Login_btn.Click += button1_Click;
            // 
            // Login_tb
            // 
            Login_tb.Location = new Point(688, 237);
            Login_tb.Name = "Login_tb";
            Login_tb.Size = new Size(125, 27);
            Login_tb.TabIndex = 3;
            // 
            // Password_tb
            // 
            Password_tb.Location = new Point(688, 270);
            Password_tb.Name = "Password_tb";
            Password_tb.PasswordChar = '*';
            Password_tb.Size = new Size(125, 27);
            Password_tb.TabIndex = 4;
            // 
            // Exit_btn
            // 
            Exit_btn.Location = new Point(602, 318);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(94, 29);
            Exit_btn.TabIndex = 5;
            Exit_btn.Text = "Exit";
            Exit_btn.UseVisualStyleBackColor = true;
            Exit_btn.Click += button2_Click;
            // 
            // LoginErr_lb
            // 
            LoginErr_lb.AutoSize = true;
            LoginErr_lb.ForeColor = Color.Red;
            LoginErr_lb.Location = new Point(819, 240);
            LoginErr_lb.Name = "LoginErr_lb";
            LoginErr_lb.Size = new Size(0, 20);
            LoginErr_lb.TabIndex = 6;
            // 
            // PasswordErr_lb
            // 
            PasswordErr_lb.AutoSize = true;
            PasswordErr_lb.ForeColor = Color.Red;
            PasswordErr_lb.Location = new Point(819, 273);
            PasswordErr_lb.Name = "PasswordErr_lb";
            PasswordErr_lb.Size = new Size(0, 20);
            PasswordErr_lb.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 712);
            Controls.Add(PasswordErr_lb);
            Controls.Add(LoginErr_lb);
            Controls.Add(Exit_btn);
            Controls.Add(Password_tb);
            Controls.Add(Login_tb);
            Controls.Add(Login_btn);
            Controls.Add(Password_lb);
            Controls.Add(Login_lb);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Login_lb;
        private Label Password_lb;
        private Button Login_btn;
        private TextBox Login_tb;
        private TextBox Password_tb;
        private Button Exit_btn;
        private Label LoginErr_lb;
        private Label PasswordErr_lb;
    }
}