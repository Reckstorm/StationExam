namespace StationExam
{
    partial class OrderEntry
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
            TotalVal_lb = new Label();
            Total_lb = new Label();
            Date_dp = new DateTimePicker();
            Date_lb = new Label();
            Car_lb = new Label();
            Employee_lb = new Label();
            Part_lb = new Label();
            Service_lb = new Label();
            Id_lb = new Label();
            CarVal_lb = new Label();
            ServiceVal_lb = new Label();
            PartVal_lb = new Label();
            EmpVal_lb = new Label();
            SuspendLayout();
            // 
            // TotalVal_lb
            // 
            TotalVal_lb.AutoSize = true;
            TotalVal_lb.Location = new Point(754, 23);
            TotalVal_lb.Name = "TotalVal_lb";
            TotalVal_lb.Size = new Size(65, 20);
            TotalVal_lb.TabIndex = 33;
            TotalVal_lb.Text = "total_val";
            // 
            // Total_lb
            // 
            Total_lb.AutoSize = true;
            Total_lb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Total_lb.Location = new Point(689, 23);
            Total_lb.Name = "Total_lb";
            Total_lb.Size = new Size(48, 20);
            Total_lb.TabIndex = 32;
            Total_lb.Text = "Total:";
            // 
            // Date_dp
            // 
            Date_dp.Enabled = false;
            Date_dp.Location = new Point(376, 20);
            Date_dp.Name = "Date_dp";
            Date_dp.Size = new Size(277, 27);
            Date_dp.TabIndex = 27;
            // 
            // Date_lb
            // 
            Date_lb.AutoSize = true;
            Date_lb.Location = new Point(320, 23);
            Date_lb.Name = "Date_lb";
            Date_lb.Size = new Size(44, 20);
            Date_lb.TabIndex = 26;
            Date_lb.Text = "Date:";
            // 
            // Car_lb
            // 
            Car_lb.AutoSize = true;
            Car_lb.Location = new Point(98, 23);
            Car_lb.Name = "Car_lb";
            Car_lb.Size = new Size(34, 20);
            Car_lb.TabIndex = 24;
            Car_lb.Text = "Car:";
            // 
            // Employee_lb
            // 
            Employee_lb.AutoSize = true;
            Employee_lb.Location = new Point(533, 74);
            Employee_lb.Name = "Employee_lb";
            Employee_lb.Size = new Size(78, 20);
            Employee_lb.TabIndex = 22;
            Employee_lb.Text = "Employee:";
            // 
            // Part_lb
            // 
            Part_lb.AutoSize = true;
            Part_lb.Location = new Point(320, 74);
            Part_lb.Name = "Part_lb";
            Part_lb.Size = new Size(37, 20);
            Part_lb.TabIndex = 20;
            Part_lb.Text = "Part:";
            // 
            // Service_lb
            // 
            Service_lb.AutoSize = true;
            Service_lb.Location = new Point(98, 74);
            Service_lb.Name = "Service_lb";
            Service_lb.Size = new Size(59, 20);
            Service_lb.TabIndex = 18;
            Service_lb.Text = "Service:";
            // 
            // Id_lb
            // 
            Id_lb.AutoSize = true;
            Id_lb.Location = new Point(41, 23);
            Id_lb.Name = "Id_lb";
            Id_lb.Size = new Size(17, 20);
            Id_lb.TabIndex = 17;
            Id_lb.Text = "0";
            // 
            // CarVal_lb
            // 
            CarVal_lb.AutoSize = true;
            CarVal_lb.Location = new Point(138, 23);
            CarVal_lb.Name = "CarVal_lb";
            CarVal_lb.Size = new Size(71, 20);
            CarVal_lb.TabIndex = 34;
            CarVal_lb.Text = "Car Value";
            // 
            // ServiceVal_lb
            // 
            ServiceVal_lb.AutoSize = true;
            ServiceVal_lb.Location = new Point(163, 74);
            ServiceVal_lb.Name = "ServiceVal_lb";
            ServiceVal_lb.Size = new Size(92, 20);
            ServiceVal_lb.TabIndex = 35;
            ServiceVal_lb.Text = "ServiceValue";
            // 
            // PartVal_lb
            // 
            PartVal_lb.AutoSize = true;
            PartVal_lb.Location = new Point(363, 74);
            PartVal_lb.Name = "PartVal_lb";
            PartVal_lb.Size = new Size(74, 20);
            PartVal_lb.TabIndex = 36;
            PartVal_lb.Text = "Part Value";
            // 
            // EmpVal_lb
            // 
            EmpVal_lb.AutoSize = true;
            EmpVal_lb.Location = new Point(617, 74);
            EmpVal_lb.Name = "EmpVal_lb";
            EmpVal_lb.Size = new Size(79, 20);
            EmpVal_lb.TabIndex = 37;
            EmpVal_lb.Text = "Emp Value";
            // 
            // OrderEntry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(EmpVal_lb);
            Controls.Add(PartVal_lb);
            Controls.Add(ServiceVal_lb);
            Controls.Add(CarVal_lb);
            Controls.Add(TotalVal_lb);
            Controls.Add(Total_lb);
            Controls.Add(Date_dp);
            Controls.Add(Date_lb);
            Controls.Add(Car_lb);
            Controls.Add(Employee_lb);
            Controls.Add(Part_lb);
            Controls.Add(Service_lb);
            Controls.Add(Id_lb);
            Name = "OrderEntry";
            Size = new Size(920, 115);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label TotalVal_lb;
        private Label Total_lb;
        public DateTimePicker Date_dp;
        private Label Date_lb;
        private Label Car_lb;
        private Label Employee_lb;
        private Label Part_lb;
        private Label Service_lb;
        public Label Id_lb;
        public Label CarVal_lb;
        public Label ServiceVal_lb;
        public Label PartVal_lb;
        public Label EmpVal_lb;
    }
}
