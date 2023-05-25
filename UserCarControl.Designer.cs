namespace StationExam
{
    partial class UserCarControl
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
            Man_cb = new ComboBox();
            VRN_lb = new Label();
            Err_lb = new Label();
            Clear = new Button();
            Save = new Button();
            Name_lb = new Label();
            Id_lb = new Label();
            VRN_tb = new TextBox();
            User_cb = new ComboBox();
            User_lb = new Label();
            Delete = new Button();
            SuspendLayout();
            // 
            // Man_cb
            // 
            Man_cb.FormattingEnabled = true;
            Man_cb.Location = new Point(192, 11);
            Man_cb.Name = "Man_cb";
            Man_cb.Size = new Size(151, 28);
            Man_cb.TabIndex = 41;
            // 
            // VRN_lb
            // 
            VRN_lb.AutoSize = true;
            VRN_lb.Location = new Point(683, 14);
            VRN_lb.Name = "VRN_lb";
            VRN_lb.Size = new Size(41, 20);
            VRN_lb.TabIndex = 39;
            VRN_lb.Text = "VRN:";
            // 
            // Err_lb
            // 
            Err_lb.AutoSize = true;
            Err_lb.ForeColor = Color.Red;
            Err_lb.Location = new Point(297, 62);
            Err_lb.Name = "Err_lb";
            Err_lb.Size = new Size(27, 20);
            Err_lb.TabIndex = 37;
            Err_lb.Text = "Err";
            // 
            // Clear
            // 
            Clear.Location = new Point(561, 58);
            Clear.Name = "Clear";
            Clear.Size = new Size(94, 29);
            Clear.TabIndex = 35;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Save
            // 
            Save.Location = new Point(761, 58);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 36;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Name_lb
            // 
            Name_lb.AutoSize = true;
            Name_lb.Location = new Point(61, 14);
            Name_lb.Name = "Name_lb";
            Name_lb.Size = new Size(126, 20);
            Name_lb.TabIndex = 34;
            Name_lb.Text = "Car manufacturer:";
            // 
            // Id_lb
            // 
            Id_lb.AutoSize = true;
            Id_lb.Location = new Point(23, 14);
            Id_lb.Name = "Id_lb";
            Id_lb.Size = new Size(17, 20);
            Id_lb.TabIndex = 33;
            Id_lb.Text = "0";
            // 
            // VRN_tb
            // 
            VRN_tb.Location = new Point(730, 11);
            VRN_tb.Name = "VRN_tb";
            VRN_tb.Size = new Size(125, 27);
            VRN_tb.TabIndex = 44;
            // 
            // User_cb
            // 
            User_cb.FormattingEnabled = true;
            User_cb.Location = new Point(480, 11);
            User_cb.Name = "User_cb";
            User_cb.Size = new Size(151, 28);
            User_cb.TabIndex = 46;
            // 
            // User_lb
            // 
            User_lb.AutoSize = true;
            User_lb.Location = new Point(395, 14);
            User_lb.Name = "User_lb";
            User_lb.Size = new Size(79, 20);
            User_lb.TabIndex = 45;
            User_lb.Text = "Car owner:";
            // 
            // Delete
            // 
            Delete.Location = new Point(661, 58);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 47;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // UserCarControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(Delete);
            Controls.Add(User_cb);
            Controls.Add(User_lb);
            Controls.Add(VRN_tb);
            Controls.Add(Man_cb);
            Controls.Add(VRN_lb);
            Controls.Add(Err_lb);
            Controls.Add(Clear);
            Controls.Add(Save);
            Controls.Add(Name_lb);
            Controls.Add(Id_lb);
            Name = "UserCarControl";
            Size = new Size(920, 94);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public ComboBox Man_cb;
        private Label VRN_lb;
        private Label Err_lb;
        private Button Clear;
        private Button Save;
        private Label Name_lb;
        private Label Id_lb;
        private TextBox VRN_tb;
        public ComboBox User_cb;
        private Label User_lb;
        private Button Delete;
    }
}
