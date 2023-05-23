namespace StationExam
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PasswordErr_lb = new Label();
            LoginErr_lb = new Label();
            Exit_btn = new Button();
            Password_tb = new TextBox();
            Login_tb = new TextBox();
            Login_btn = new Button();
            Password_lb = new Label();
            Login_lb = new Label();
            SuspendLayout();
            // 
            // PasswordErr_lb
            // 
            PasswordErr_lb.AutoSize = true;
            PasswordErr_lb.ForeColor = Color.Red;
            PasswordErr_lb.Location = new Point(808, 318);
            PasswordErr_lb.Name = "PasswordErr_lb";
            PasswordErr_lb.Size = new Size(0, 20);
            PasswordErr_lb.TabIndex = 15;
            // 
            // LoginErr_lb
            // 
            LoginErr_lb.AutoSize = true;
            LoginErr_lb.ForeColor = Color.Red;
            LoginErr_lb.Location = new Point(808, 285);
            LoginErr_lb.Name = "LoginErr_lb";
            LoginErr_lb.Size = new Size(0, 20);
            LoginErr_lb.TabIndex = 14;
            // 
            // Exit_btn
            // 
            Exit_btn.Location = new Point(591, 363);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(94, 29);
            Exit_btn.TabIndex = 13;
            Exit_btn.Text = "Exit";
            Exit_btn.UseVisualStyleBackColor = true;
            Exit_btn.Click += Exit_btn_Click;
            // 
            // Password_tb
            // 
            Password_tb.Location = new Point(677, 315);
            Password_tb.Name = "Password_tb";
            Password_tb.PasswordChar = '*';
            Password_tb.Size = new Size(125, 27);
            Password_tb.TabIndex = 12;
            // 
            // Login_tb
            // 
            Login_tb.Location = new Point(677, 282);
            Login_tb.Name = "Login_tb";
            Login_tb.Size = new Size(125, 27);
            Login_tb.TabIndex = 11;
            // 
            // Login_btn
            // 
            Login_btn.Location = new Point(708, 363);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(94, 29);
            Login_btn.TabIndex = 10;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = true;
            Login_btn.Click += Login_btn_Click;
            // 
            // Password_lb
            // 
            Password_lb.AutoSize = true;
            Password_lb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Password_lb.Location = new Point(591, 318);
            Password_lb.Name = "Password_lb";
            Password_lb.Size = new Size(80, 20);
            Password_lb.TabIndex = 9;
            Password_lb.Text = "Password:";
            // 
            // Login_lb
            // 
            Login_lb.AutoSize = true;
            Login_lb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Login_lb.Location = new Point(591, 285);
            Login_lb.Name = "Login_lb";
            Login_lb.Size = new Size(52, 20);
            Login_lb.TabIndex = 8;
            Login_lb.Text = "Login:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PasswordErr_lb);
            Controls.Add(LoginErr_lb);
            Controls.Add(Exit_btn);
            Controls.Add(Password_tb);
            Controls.Add(Login_tb);
            Controls.Add(Login_btn);
            Controls.Add(Password_lb);
            Controls.Add(Login_lb);
            Name = "Login";
            Size = new Size(1400, 760);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PasswordErr_lb;
        private Label LoginErr_lb;
        private Button Exit_btn;
        private TextBox Password_tb;
        private TextBox Login_tb;
        private Button Login_btn;
        private Label Password_lb;
        private Label Login_lb;
    }
}
