namespace StationExam
{
    partial class UserEntry
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
            Role_lb = new Label();
            Login_lb = new Label();
            Name_lb = new Label();
            Id_lb = new Label();
            NameVal_lb = new Label();
            LoginVal_lb = new Label();
            RoleVal_lb = new Label();
            SuspendLayout();
            // 
            // Role_lb
            // 
            Role_lb.AutoSize = true;
            Role_lb.Location = new Point(682, 15);
            Role_lb.Name = "Role_lb";
            Role_lb.Size = new Size(42, 20);
            Role_lb.TabIndex = 21;
            Role_lb.Text = "Role:";
            // 
            // Login_lb
            // 
            Login_lb.AutoSize = true;
            Login_lb.Location = new Point(432, 15);
            Login_lb.Name = "Login_lb";
            Login_lb.Size = new Size(49, 20);
            Login_lb.TabIndex = 17;
            Login_lb.Text = "Login:";
            // 
            // Name_lb
            // 
            Name_lb.AutoSize = true;
            Name_lb.Location = new Point(166, 15);
            Name_lb.Name = "Name_lb";
            Name_lb.Size = new Size(52, 20);
            Name_lb.TabIndex = 15;
            Name_lb.Text = "Name:";
            // 
            // Id_lb
            // 
            Id_lb.AutoSize = true;
            Id_lb.Location = new Point(43, 15);
            Id_lb.Name = "Id_lb";
            Id_lb.Size = new Size(17, 20);
            Id_lb.TabIndex = 14;
            Id_lb.Text = "0";
            // 
            // NameVal_lb
            // 
            NameVal_lb.AutoSize = true;
            NameVal_lb.Location = new Point(224, 15);
            NameVal_lb.Name = "NameVal_lb";
            NameVal_lb.Size = new Size(33, 20);
            NameVal_lb.TabIndex = 22;
            NameVal_lb.Text = "null";
            // 
            // LoginVal_lb
            // 
            LoginVal_lb.AutoSize = true;
            LoginVal_lb.Location = new Point(487, 15);
            LoginVal_lb.Name = "LoginVal_lb";
            LoginVal_lb.Size = new Size(33, 20);
            LoginVal_lb.TabIndex = 23;
            LoginVal_lb.Text = "null";
            // 
            // RoleVal_lb
            // 
            RoleVal_lb.AutoSize = true;
            RoleVal_lb.Location = new Point(730, 15);
            RoleVal_lb.Name = "RoleVal_lb";
            RoleVal_lb.Size = new Size(33, 20);
            RoleVal_lb.TabIndex = 25;
            RoleVal_lb.Text = "null";
            // 
            // UserEntry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(RoleVal_lb);
            Controls.Add(LoginVal_lb);
            Controls.Add(NameVal_lb);
            Controls.Add(Role_lb);
            Controls.Add(Login_lb);
            Controls.Add(Name_lb);
            Controls.Add(Id_lb);
            Name = "UserEntry";
            Size = new Size(920, 51);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Role_lb;
        private Label Login_lb;
        private Label Name_lb;
        public Label Id_lb;
        public Label NameVal_lb;
        public Label LoginVal_lb;
        public Label RoleVal_lb;
    }
}
