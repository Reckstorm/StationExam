namespace StationExam
{
    partial class UserItem
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
            Id_lb = new Label();
            Name_lb = new Label();
            Name_tb = new TextBox();
            Login_lb = new Label();
            Login_tb = new TextBox();
            Password_tb = new TextBox();
            Password_lb = new Label();
            Role_lb = new Label();
            Delete = new Button();
            Save = new Button();
            Role_cb = new ComboBox();
            Err_lb = new Label();
            SuspendLayout();
            // 
            // Id_lb
            // 
            Id_lb.AutoSize = true;
            Id_lb.Location = new Point(18, 22);
            Id_lb.Name = "Id_lb";
            Id_lb.Size = new Size(17, 20);
            Id_lb.TabIndex = 0;
            Id_lb.Text = "0";
            // 
            // Name_lb
            // 
            Name_lb.AutoSize = true;
            Name_lb.Location = new Point(64, 22);
            Name_lb.Name = "Name_lb";
            Name_lb.Size = new Size(52, 20);
            Name_lb.TabIndex = 2;
            Name_lb.Text = "Name:";
            // 
            // Name_tb
            // 
            Name_tb.Location = new Point(120, 19);
            Name_tb.Name = "Name_tb";
            Name_tb.Size = new Size(125, 27);
            Name_tb.TabIndex = 3;
            // 
            // Login_lb
            // 
            Login_lb.AutoSize = true;
            Login_lb.Location = new Point(269, 22);
            Login_lb.Name = "Login_lb";
            Login_lb.Size = new Size(49, 20);
            Login_lb.TabIndex = 4;
            Login_lb.Text = "Login:";
            // 
            // Login_tb
            // 
            Login_tb.Location = new Point(325, 19);
            Login_tb.Name = "Login_tb";
            Login_tb.Size = new Size(125, 27);
            Login_tb.TabIndex = 5;
            // 
            // Password_tb
            // 
            Password_tb.Location = new Point(555, 19);
            Password_tb.Name = "Password_tb";
            Password_tb.PasswordChar = '*';
            Password_tb.Size = new Size(125, 27);
            Password_tb.TabIndex = 7;
            // 
            // Password_lb
            // 
            Password_lb.AutoSize = true;
            Password_lb.Location = new Point(477, 22);
            Password_lb.Name = "Password_lb";
            Password_lb.Size = new Size(73, 20);
            Password_lb.TabIndex = 6;
            Password_lb.Text = "Password:";
            // 
            // Role_lb
            // 
            Role_lb.AutoSize = true;
            Role_lb.Location = new Point(694, 22);
            Role_lb.Name = "Role_lb";
            Role_lb.Size = new Size(42, 20);
            Role_lb.TabIndex = 8;
            Role_lb.Text = "Role:";
            // 
            // Delete
            // 
            Delete.Location = new Point(699, 66);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 10;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Save
            // 
            Save.Location = new Point(799, 66);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 11;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += button2_Click;
            // 
            // Role_cb
            // 
            Role_cb.FormattingEnabled = true;
            Role_cb.Location = new Point(742, 18);
            Role_cb.Name = "Role_cb";
            Role_cb.Size = new Size(151, 28);
            Role_cb.TabIndex = 13;
            // 
            // Err_lb
            // 
            Err_lb.AutoSize = true;
            Err_lb.ForeColor = Color.Red;
            Err_lb.Location = new Point(325, 66);
            Err_lb.Name = "Err_lb";
            Err_lb.Size = new Size(0, 20);
            Err_lb.TabIndex = 14;
            // 
            // UserItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Err_lb);
            Controls.Add(Role_cb);
            Controls.Add(Delete);
            Controls.Add(Save);
            Controls.Add(Role_lb);
            Controls.Add(Password_tb);
            Controls.Add(Password_lb);
            Controls.Add(Login_tb);
            Controls.Add(Login_lb);
            Controls.Add(Name_tb);
            Controls.Add(Name_lb);
            Controls.Add(Id_lb);
            Name = "UserItem";
            Size = new Size(917, 114);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Id_lb;
        private Label Name_lb;
        private Label Login_lb;
        private TextBox Name_tb;
        private Label Role_lb;
        private TextBox Login_tb;
        private TextBox Password_tb;
        private Label Password_lb;
        private Button Delete;
        private Button Save;
        private ComboBox Role_cb;
        private Label Err_lb;
    }
}
