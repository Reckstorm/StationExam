using Dapper;
using Microsoft.VisualBasic.ApplicationServices;
using StationExam.Models;
using StationExam.Models.Essentials;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationExam
{
    public partial class UserCarControl : UserControl
    {
        public UserCarControl()
        {
            InitializeComponent();
            Load += DefaultData;
        }

        public void SetCarEntry(UserCarEntry car)
        {
            this.Id_lb.Text = car.Id_lb.Text;
            this.Man_cb.SelectedItem = car.ManVal_lb.Text;
            this.User_cb.SelectedItem = car.OwnerVal_lb.Text;
            this.VRN_tb.Text = car.VRNVal_lb.Text;
        }

        public void DefaultData(object sender, EventArgs e)
        {
            ServiceWindow parent = this.Parent.Parent as ServiceWindow;
            this.Id_lb.Text = (parent.cars.Last().Id + 1).ToString();
            this.Err_lb.Text = string.Empty;
            this.VRN_tb.Text = string.Empty;
            this.Man_cb.SelectedItem = null;
            this.User_cb.SelectedItem = null;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ServiceWindow parent = this.Parent.Parent as ServiceWindow;
            DefaultData(sender, e);
            parent.RenderCarManagement(sender, e);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Err_lb.Text = string.Empty;
            ServiceWindow parent = this.Parent.Parent as ServiceWindow;

            if (parent.cars.Any(car => car.VRN.Equals(this.VRN_tb.Text)))
            {
                using (SqlConnection conn = new SqlConnection(parent.connection))
                {
                    conn.Open();
                    conn.Execute("UPDATE [Cars] SET VRN = @VRN, ModelID = @ModelID, UserID = @UserID WHERE VRN = @VRN",
                        new
                        {
                            VRN = this.VRN_tb.Text,
                            ModelID = parent.carModels.Find(car => car.Model.Equals(this.Man_cb.SelectedItem)).Id,
                            UserID = parent.users.Find(user => user.Name.Equals(this.User_cb.SelectedItem)).Id
                        });
                    this.Err_lb.ForeColor = Color.Green;
                    this.Err_lb.Text = "Car updated";
                }
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(parent.connection))
                {
                    conn.Open();
                    conn.Execute("INSERT INTO [Cars] ([VRN], [ModelID], [UserID]) VALUES (@VRN, @ModelID, @UserID)",
                        new
                        {
                            VRN = this.VRN_tb.Text,
                            ModelID = parent.carModels.Find(car => car.Model.Equals(this.Man_cb.SelectedItem)).Id,
                            UserID = parent.users.Find(user => user.Name.Equals(this.User_cb.SelectedItem)).Id
                        });
                    this.Err_lb.ForeColor = Color.Green;
                    this.Err_lb.Text = "Car created";
                }
            }
            DefaultData(sender, e);
            parent.RenderCarManagement(sender, e);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.Err_lb.Text = string.Empty;
            ServiceWindow parent = this.Parent.Parent as ServiceWindow;

            if (parent.cars.Any(car => car.VRN.Equals(this.VRN_tb.Text)))
            {
                using (SqlConnection conn = new SqlConnection(parent.connection))
                {
                    conn.Open();
                    conn.Execute("DELETE FROM [Cars] WHERE VRN = @VRN", new { VRN = this.VRN_tb.Text });
                    this.Err_lb.ForeColor = Color.Green;
                    this.Err_lb.Text = "User deleted";
                }
            }
            else
            {
                this.Err_lb.ForeColor = Color.Red;
                this.Err_lb.Text = "There is no such car";
            }
            DefaultData(sender, e);
            parent.RenderCarManagement(sender, e);
        }
    }
}
