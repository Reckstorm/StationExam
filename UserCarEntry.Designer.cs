namespace StationExam
{
    partial class UserCarEntry
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
            VRNVal_lb = new Label();
            OwnerVal_lb = new Label();
            ManVal_lb = new Label();
            VRN_lb = new Label();
            Owner_lb = new Label();
            Man_lb = new Label();
            Id_lb = new Label();
            SuspendLayout();
            // 
            // VRNVal_lb
            // 
            VRNVal_lb.AutoSize = true;
            VRNVal_lb.Location = new Point(753, 14);
            VRNVal_lb.Name = "VRNVal_lb";
            VRNVal_lb.Size = new Size(33, 20);
            VRNVal_lb.TabIndex = 32;
            VRNVal_lb.Text = "null";
            // 
            // OwnerVal_lb
            // 
            OwnerVal_lb.AutoSize = true;
            OwnerVal_lb.Location = new Point(513, 14);
            OwnerVal_lb.Name = "OwnerVal_lb";
            OwnerVal_lb.Size = new Size(33, 20);
            OwnerVal_lb.TabIndex = 31;
            OwnerVal_lb.Text = "null";
            // 
            // ManVal_lb
            // 
            ManVal_lb.AutoSize = true;
            ManVal_lb.Location = new Point(304, 14);
            ManVal_lb.Name = "ManVal_lb";
            ManVal_lb.Size = new Size(33, 20);
            ManVal_lb.TabIndex = 30;
            ManVal_lb.Text = "null";
            // 
            // VRN_lb
            // 
            VRN_lb.AutoSize = true;
            VRN_lb.Location = new Point(705, 14);
            VRN_lb.Name = "VRN_lb";
            VRN_lb.Size = new Size(41, 20);
            VRN_lb.TabIndex = 29;
            VRN_lb.Text = "VRN:";
            // 
            // Owner_lb
            // 
            Owner_lb.AutoSize = true;
            Owner_lb.Location = new Point(455, 14);
            Owner_lb.Name = "Owner_lb";
            Owner_lb.Size = new Size(55, 20);
            Owner_lb.TabIndex = 28;
            Owner_lb.Text = "Owner:";
            // 
            // Man_lb
            // 
            Man_lb.AutoSize = true;
            Man_lb.Location = new Point(198, 14);
            Man_lb.Name = "Man_lb";
            Man_lb.Size = new Size(100, 20);
            Man_lb.TabIndex = 27;
            Man_lb.Text = "Manufacturer:";
            // 
            // Id_lb
            // 
            Id_lb.AutoSize = true;
            Id_lb.Location = new Point(66, 14);
            Id_lb.Name = "Id_lb";
            Id_lb.Size = new Size(17, 20);
            Id_lb.TabIndex = 26;
            Id_lb.Text = "0";
            // 
            // UserCarEntry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(VRNVal_lb);
            Controls.Add(OwnerVal_lb);
            Controls.Add(ManVal_lb);
            Controls.Add(VRN_lb);
            Controls.Add(Owner_lb);
            Controls.Add(Man_lb);
            Controls.Add(Id_lb);
            Name = "UserCarEntry";
            Size = new Size(920, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label VRNVal_lb;
        public Label OwnerVal_lb;
        public Label ManVal_lb;
        private Label VRN_lb;
        private Label Owner_lb;
        private Label Man_lb;
        public Label Id_lb;
    }
}
