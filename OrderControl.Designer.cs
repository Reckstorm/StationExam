namespace StationExam
{
    partial class OrderControl
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
            Service_lb = new Label();
            Service_cb = new ComboBox();
            Part_cb = new ComboBox();
            Part_lb = new Label();
            Employee_cb = new ComboBox();
            Employee_lb = new Label();
            Car_cb = new ComboBox();
            Car_lb = new Label();
            Date_lb = new Label();
            Date_dp = new DateTimePicker();
            Clear = new Button();
            Complete = new Button();
            Save = new Button();
            Err_lb = new Label();
            Total_lb = new Label();
            TotalVal_lb = new Label();
            SuspendLayout();
            // 
            // Id_lb
            // 
            Id_lb.AutoSize = true;
            Id_lb.Location = new Point(24, 26);
            Id_lb.Name = "Id_lb";
            Id_lb.Size = new Size(17, 20);
            Id_lb.TabIndex = 0;
            Id_lb.Text = "0";
            // 
            // Service_lb
            // 
            Service_lb.AutoSize = true;
            Service_lb.Location = new Point(81, 77);
            Service_lb.Name = "Service_lb";
            Service_lb.Size = new Size(59, 20);
            Service_lb.TabIndex = 1;
            Service_lb.Text = "Service:";
            // 
            // Service_cb
            // 
            Service_cb.FormattingEnabled = true;
            Service_cb.Location = new Point(146, 74);
            Service_cb.Name = "Service_cb";
            Service_cb.Size = new Size(151, 28);
            Service_cb.TabIndex = 2;
            Service_cb.SelectedIndexChanged += Service_cb_SelectedIndexChanged;
            // 
            // Part_cb
            // 
            Part_cb.FormattingEnabled = true;
            Part_cb.Location = new Point(359, 74);
            Part_cb.Name = "Part_cb";
            Part_cb.Size = new Size(151, 28);
            Part_cb.TabIndex = 4;
            Part_cb.SelectedIndexChanged += Part_cb_SelectedIndexChanged;
            // 
            // Part_lb
            // 
            Part_lb.AutoSize = true;
            Part_lb.Location = new Point(303, 77);
            Part_lb.Name = "Part_lb";
            Part_lb.Size = new Size(37, 20);
            Part_lb.TabIndex = 3;
            Part_lb.Text = "Part:";
            // 
            // Employee_cb
            // 
            Employee_cb.FormattingEnabled = true;
            Employee_cb.Location = new Point(600, 74);
            Employee_cb.Name = "Employee_cb";
            Employee_cb.Size = new Size(151, 28);
            Employee_cb.TabIndex = 6;
            // 
            // Employee_lb
            // 
            Employee_lb.AutoSize = true;
            Employee_lb.Location = new Point(516, 77);
            Employee_lb.Name = "Employee_lb";
            Employee_lb.Size = new Size(78, 20);
            Employee_lb.TabIndex = 5;
            Employee_lb.Text = "Employee:";
            // 
            // Car_cb
            // 
            Car_cb.FormattingEnabled = true;
            Car_cb.Location = new Point(146, 23);
            Car_cb.Name = "Car_cb";
            Car_cb.Size = new Size(151, 28);
            Car_cb.TabIndex = 8;
            Car_cb.SelectedIndexChanged += Car_cb_SelectedIndexChanged;
            // 
            // Car_lb
            // 
            Car_lb.AutoSize = true;
            Car_lb.Location = new Point(81, 26);
            Car_lb.Name = "Car_lb";
            Car_lb.Size = new Size(34, 20);
            Car_lb.TabIndex = 7;
            Car_lb.Text = "Car:";
            // 
            // Date_lb
            // 
            Date_lb.AutoSize = true;
            Date_lb.Location = new Point(303, 26);
            Date_lb.Name = "Date_lb";
            Date_lb.Size = new Size(44, 20);
            Date_lb.TabIndex = 9;
            Date_lb.Text = "Date:";
            // 
            // Date_dp
            // 
            Date_dp.Location = new Point(359, 23);
            Date_dp.Name = "Date_dp";
            Date_dp.Size = new Size(277, 27);
            Date_dp.TabIndex = 10;
            // 
            // Clear
            // 
            Clear.Location = new Point(568, 132);
            Clear.Name = "Clear";
            Clear.Size = new Size(94, 29);
            Clear.TabIndex = 11;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Complete
            // 
            Complete.Location = new Point(668, 132);
            Complete.Name = "Complete";
            Complete.Size = new Size(94, 29);
            Complete.TabIndex = 12;
            Complete.Text = "Complete";
            Complete.UseVisualStyleBackColor = true;
            Complete.Click += Complete_Click;
            // 
            // Save
            // 
            Save.Location = new Point(768, 132);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 13;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Err_lb
            // 
            Err_lb.AutoSize = true;
            Err_lb.ForeColor = Color.Red;
            Err_lb.Location = new Point(330, 136);
            Err_lb.Name = "Err_lb";
            Err_lb.Size = new Size(27, 20);
            Err_lb.TabIndex = 14;
            Err_lb.Text = "Err";
            // 
            // Total_lb
            // 
            Total_lb.AutoSize = true;
            Total_lb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Total_lb.Location = new Point(81, 132);
            Total_lb.Name = "Total_lb";
            Total_lb.Size = new Size(48, 20);
            Total_lb.TabIndex = 15;
            Total_lb.Text = "Total:";
            // 
            // TotalVal_lb
            // 
            TotalVal_lb.AutoSize = true;
            TotalVal_lb.Location = new Point(146, 132);
            TotalVal_lb.Name = "TotalVal_lb";
            TotalVal_lb.Size = new Size(65, 20);
            TotalVal_lb.TabIndex = 16;
            TotalVal_lb.Text = "total_val";
            // 
            // OrderControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(TotalVal_lb);
            Controls.Add(Total_lb);
            Controls.Add(Err_lb);
            Controls.Add(Save);
            Controls.Add(Complete);
            Controls.Add(Clear);
            Controls.Add(Date_dp);
            Controls.Add(Date_lb);
            Controls.Add(Car_cb);
            Controls.Add(Car_lb);
            Controls.Add(Employee_cb);
            Controls.Add(Employee_lb);
            Controls.Add(Part_cb);
            Controls.Add(Part_lb);
            Controls.Add(Service_cb);
            Controls.Add(Service_lb);
            Controls.Add(Id_lb);
            Name = "OrderControl";
            Size = new Size(920, 175);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Id_lb;
        private Label Service_lb;
        public ComboBox Service_cb;
        public ComboBox Part_cb;
        private Label Part_lb;
        private ComboBox Employee_cb;
        private Label Employee_lb;
        public ComboBox Car_cb;
        private Label Car_lb;
        private Label Date_lb;
        private DateTimePicker Date_dp;
        private Button Clear;
        private Button Complete;
        private Button Save;
        private Label Err_lb;
        private Label Total_lb;
        private Label TotalVal_lb;
    }
}
