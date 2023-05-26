using Dapper;
using StationExam.Models;
using StationExam.Models.Essentials;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace StationExam
{
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                DefaultData(s, e);
                this.Err_lb.Text = string.Empty;
            };
        }
        private void Car_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceWindow parent = this.Parent.Parent as ServiceWindow;
            string temp = Car_cb.SelectedItem.ToString();
            string tempModel = parent.cars.Find(car => car.VRN.Equals(temp)).Model;
            Part_cb.Items.Clear();
            parent.parts.ForEach(part =>
            {
                if (part.Model == tempModel) Part_cb.Items.Add(part);
            });
        }

        private void Service_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceWindow parent = this.Parent.Parent as ServiceWindow;

            Services tmpSrv = parent.services.Find(service => service.ToString().Equals(Service_cb.SelectedItem.ToString()));
            if (Part_cb.SelectedItem == null) Part_cb.SelectedIndex = 0;
            Parts tmpPart = parent.parts.Find(part => part.ToString().Equals(Part_cb.SelectedItem.ToString()));

            int id = tmpSrv.SpecialityId;
            List<int> ids = new List<int>();

            using (SqlConnection conn = new SqlConnection(parent.connection))
            {
                conn.Open();
                ids = conn.Query<int>("SELECT EmployeeSpecialities.UserID " +
                    "FROM EmployeeSpecialities " +
                    "WHERE SpecialityID = @ID", new { ID = id }).AsList();
            }
            this.Employee_cb.Items.Clear();
            parent.users.ForEach(user => ids.ForEach(userId =>
            {
                if (user.Id == userId) Employee_cb.Items.Add(user.Name);
            }));
            this.Employee_cb.SelectedIndex = Employee_cb.Items.Count > 0 ? 0 : -1;
            TotalVal_lb.Text = (tmpSrv.Price + tmpPart.Price).ToString();
        }

        private void Part_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceWindow parent = this.Parent.Parent as ServiceWindow;
            Parts tmpPart = parent.parts.Find(part => part.ToString().Equals(Part_cb.SelectedItem.ToString()));
            if (Service_cb.SelectedItem == null) Service_cb.SelectedIndex = 0;
            Services tmpSrv = parent.services.Find(service => service.ToString().Equals(Service_cb.SelectedItem.ToString()));
            TotalVal_lb.Text = (tmpSrv.Price + tmpPart.Price).ToString();
        }

        private void DefaultData(object sender, EventArgs e)
        {
            ServiceWindow parent = this.Parent.Parent as ServiceWindow;
            this.Id_lb.Text = parent.orders.Count > 0 ? (parent.orders.Last().Id + 1).ToString() : "1";
            this.TotalVal_lb.Text = "0";
            this.Date_dp.Value = DateTime.Now;

            this.Car_cb.SelectedIndex = 0;
            this.Service_cb.SelectedIndex = 0;
            this.Part_cb.SelectedIndex = 0;
            this.Employee_cb.SelectedIndex = Employee_cb.Items.Count > 0 ? 0 : -1;
        }

        public void SetOrderEntry(OrderEntry order)
        {
            ServiceWindow parent = this.Parent.Parent as ServiceWindow;
            this.Err_lb.Text = string.Empty;
            this.Id_lb.Text = order.Id_lb.Text;
            this.Car_cb.SelectedItem = order.CarVal_lb.Text;
            this.Service_cb.SelectedItem = order.ServiceVal_lb.Text;
            this.Part_cb.SelectedItem = order.PartVal_lb.Text;
            this.Employee_cb.SelectedItem = order.EmpVal_lb.Text;
            this.TotalVal_lb.Text = order.TotalVal_lb.Text;
            this.Date_dp = order.Date_dp;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            DefaultData(sender, e);
            this.Err_lb.Text = string.Empty;
        }

        private void Complete_Click(object sender, EventArgs e)
        {
            ServiceWindow parent = this.Parent.Parent as ServiceWindow;
            if (parent.orders.Any(order => order.Id == int.Parse(this.Id_lb.Text)))
            {
                using (SqlConnection conn = new SqlConnection(parent.connection))
                {
                    conn.Open();
                    conn.Execute("DELETE FROM [Orders] WHERE Id = @Id", new { Id = int.Parse(this.Id_lb.Text) });
                    this.Err_lb.ForeColor = Color.Green;
                    this.Err_lb.Text = "Order complete";
                }
            }
            else
            {
                this.Err_lb.ForeColor = Color.Red;
                this.Err_lb.Text = "There is no such order";
            }
            DefaultData(sender, e);
            parent.RenderOrderManagement(sender, e);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Err_lb.Text = string.Empty;
            ServiceWindow parent = this.Parent.Parent as ServiceWindow;

            if (parent.orders.Any(order => order.Id == int.Parse(this.Id_lb.Text)))
            {
                using (SqlConnection conn = new SqlConnection(parent.connection))
                {
                    conn.Open();
                    conn.Execute("UPDATE [Orders] SET ServiceID = @ServiceID, PartID = @PartID, CarID = @CarID, EmployeeID = @EmployeeID, DateTime = @DateTime WHERE Id = @Id",
                        new
                        {
                            ServiceID = parent.services.Find(service => service.ToString().Equals(Service_cb.SelectedItem.ToString())).Id,
                            PartID = parent.parts.Find(part => part.ToString().Equals(Part_cb.SelectedItem.ToString())).Id,
                            CarID = parent.cars.Find(x => x.VRN.Equals(this.Car_cb.SelectedItem.ToString())).Id,
                            EmployeeID = parent.users.Find(x => x.Name.Equals(this.Employee_cb.SelectedItem)).Id,
                            DateTime = Date_dp.Value,
                            Id = int.Parse(this.Id_lb.Text)
                        });
                    this.Err_lb.ForeColor = Color.Green;
                    this.Err_lb.Text = "Order updated";
                }
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(parent.connection))
                {
                    conn.Open();
                    conn.Execute("INSERT INTO [Orders] ([Id], [ServiceID], [PartID], [CarID], [EmployeeID], [DateTime]) VALUES (@Id, @ServiceID, @PartID, @CarID, @EmployeeID, @DateTime)",
                        new
                        {
                            Id = int.Parse(this.Id_lb.Text),
                            ServiceID = parent.services.Find(service => service.ToString().Equals(Service_cb.SelectedItem.ToString())).Id,
                            PartID = parent.parts.Find(part => part.ToString().Equals(Part_cb.SelectedItem.ToString())).Id,
                            CarID = parent.cars.Find(x => x.VRN.Equals(this.Car_cb.SelectedItem.ToString())).Id,
                            EmployeeID = parent.users.Find(x => x.Name.Equals(this.Employee_cb.SelectedItem)).Id,
                            DateTime = Date_dp.Value
                        });
                    this.Err_lb.ForeColor = Color.Green;
                    this.Err_lb.Text = "User created";
                }
            }
            DefaultData(sender, e);
            parent.RenderOrderManagement(sender, e);
        }
    }
}
