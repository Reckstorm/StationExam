namespace StationExam
{
    partial class UserSpecControl
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
            Err_lb = new Label();
            Clear = new Button();
            Save = new Button();
            Name_lb = new Label();
            Id_lb = new Label();
            NameVal_lb = new Label();
            Specs_lb = new Label();
            SpecsVal_lb = new Label();
            Specs_cb = new ComboBox();
            Add = new Button();
            Remove = new Button();
            SuspendLayout();
            // 
            // Err_lb
            // 
            Err_lb.AutoSize = true;
            Err_lb.ForeColor = Color.Red;
            Err_lb.Location = new Point(440, 112);
            Err_lb.Name = "Err_lb";
            Err_lb.Size = new Size(0, 20);
            Err_lb.TabIndex = 26;
            // 
            // Clear
            // 
            Clear.Location = new Point(695, 108);
            Clear.Name = "Clear";
            Clear.Size = new Size(94, 29);
            Clear.TabIndex = 23;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Save
            // 
            Save.Location = new Point(795, 108);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 24;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Name_lb
            // 
            Name_lb.AutoSize = true;
            Name_lb.Location = new Point(60, 15);
            Name_lb.Name = "Name_lb";
            Name_lb.Size = new Size(52, 20);
            Name_lb.TabIndex = 16;
            Name_lb.Text = "Name:";
            // 
            // Id_lb
            // 
            Id_lb.AutoSize = true;
            Id_lb.Location = new Point(14, 15);
            Id_lb.Name = "Id_lb";
            Id_lb.Size = new Size(17, 20);
            Id_lb.TabIndex = 15;
            Id_lb.Text = "0";
            // 
            // NameVal_lb
            // 
            NameVal_lb.AutoSize = true;
            NameVal_lb.Location = new Point(118, 15);
            NameVal_lb.Name = "NameVal_lb";
            NameVal_lb.Size = new Size(0, 20);
            NameVal_lb.TabIndex = 27;
            // 
            // Specs_lb
            // 
            Specs_lb.AutoSize = true;
            Specs_lb.Location = new Point(281, 15);
            Specs_lb.Name = "Specs_lb";
            Specs_lb.Size = new Size(139, 20);
            Specs_lb.TabIndex = 28;
            Specs_lb.Text = "Current Specialities:";
            // 
            // SpecsVal_lb
            // 
            SpecsVal_lb.AutoSize = true;
            SpecsVal_lb.Location = new Point(440, 15);
            SpecsVal_lb.Name = "SpecsVal_lb";
            SpecsVal_lb.Size = new Size(0, 20);
            SpecsVal_lb.TabIndex = 29;
            // 
            // Specs_cb
            // 
            Specs_cb.FormattingEnabled = true;
            Specs_cb.Location = new Point(281, 68);
            Specs_cb.Name = "Specs_cb";
            Specs_cb.Size = new Size(151, 28);
            Specs_cb.TabIndex = 30;
            // 
            // Add
            // 
            Add.Location = new Point(440, 68);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 31;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Remove
            // 
            Remove.Location = new Point(540, 68);
            Remove.Name = "Remove";
            Remove.Size = new Size(94, 29);
            Remove.TabIndex = 32;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = true;
            Remove.Click += Remove_Click;
            // 
            // UserSpecControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(Remove);
            Controls.Add(Add);
            Controls.Add(Specs_cb);
            Controls.Add(SpecsVal_lb);
            Controls.Add(Specs_lb);
            Controls.Add(NameVal_lb);
            Controls.Add(Err_lb);
            Controls.Add(Clear);
            Controls.Add(Save);
            Controls.Add(Name_lb);
            Controls.Add(Id_lb);
            Name = "UserSpecControl";
            Size = new Size(920, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Err_lb;
        private ComboBox Role_cb;
        private Button Clear;
        private Button Save;
        private Label Role_lb;
        private TextBox Password_tb;
        private Label Password_lb;
        private TextBox Login_tb;
        private Label Login_lb;
        private TextBox Name_tb;
        private Label Name_lb;
        private Label Id_lb;
        private Label NameVal_lb;
        private Label Specs_lb;
        private Label SpecsVal_lb;
        public ComboBox Specs_cb;
        private Button Add;
        private Button Remove;
    }
}
