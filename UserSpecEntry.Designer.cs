namespace StationExam
{
    partial class UserSpecEntry
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
            SpecVal_lb = new Label();
            NameVal_lb = new Label();
            Specs_lb = new Label();
            Name_lb = new Label();
            Id_lb = new Label();
            SuspendLayout();
            // 
            // SpecVal_lb
            // 
            SpecVal_lb.AutoSize = true;
            SpecVal_lb.Location = new Point(498, 16);
            SpecVal_lb.Name = "SpecVal_lb";
            SpecVal_lb.Size = new Size(33, 20);
            SpecVal_lb.TabIndex = 32;
            SpecVal_lb.Text = "null";
            // 
            // NameVal_lb
            // 
            NameVal_lb.AutoSize = true;
            NameVal_lb.Location = new Point(250, 16);
            NameVal_lb.Name = "NameVal_lb";
            NameVal_lb.Size = new Size(33, 20);
            NameVal_lb.TabIndex = 30;
            NameVal_lb.Text = "null";
            // 
            // Specs_lb
            // 
            Specs_lb.AutoSize = true;
            Specs_lb.Location = new Point(405, 16);
            Specs_lb.Name = "Specs_lb";
            Specs_lb.Size = new Size(87, 20);
            Specs_lb.TabIndex = 29;
            Specs_lb.Text = "Specialities:";
            // 
            // Name_lb
            // 
            Name_lb.AutoSize = true;
            Name_lb.Location = new Point(192, 16);
            Name_lb.Name = "Name_lb";
            Name_lb.Size = new Size(52, 20);
            Name_lb.TabIndex = 27;
            Name_lb.Text = "Name:";
            // 
            // Id_lb
            // 
            Id_lb.AutoSize = true;
            Id_lb.Location = new Point(69, 16);
            Id_lb.Name = "Id_lb";
            Id_lb.Size = new Size(17, 20);
            Id_lb.TabIndex = 26;
            Id_lb.Text = "0";
            // 
            // UserSpecEntry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(SpecVal_lb);
            Controls.Add(NameVal_lb);
            Controls.Add(Specs_lb);
            Controls.Add(Name_lb);
            Controls.Add(Id_lb);
            Name = "UserSpecEntry";
            Size = new Size(920, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label SpecVal_lb;
        public Label NameVal_lb;
        private Label Specs_lb;
        private Label Name_lb;
        public Label Id_lb;
    }
}
