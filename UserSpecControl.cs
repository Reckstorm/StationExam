using Dapper;
using StationExam.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace StationExam
{
    public partial class UserSpecControl : UserControl
    {
        public UserSpecControl()
        {
            InitializeComponent();
        }

        public void SetUserSpecEntry(UserSpecEntry user)
        {
            ServiceWindow parent = this.Parent.Parent as ServiceWindow;
            this.Id_lb.Text = user.Id_lb.Text;
            this.NameVal_lb.Text = user.NameVal_lb.Text;
            this.SpecsVal_lb.Text = user.SpecVal_lb.Text;
        }

        private void DefaultData()
        {
            this.Err_lb.Text = string.Empty;
            this.Id_lb.Text = "0";
            this.NameVal_lb.Text = string.Empty;
            this.SpecsVal_lb.Text = string.Empty;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            List<string> strings = this.SpecsVal_lb.Text.Split(',').AsList();
            if (strings.Any(s => s.Equals(this.Specs_cb.SelectedItem)))
            {
                this.Err_lb.ForeColor = Color.Red;
                this.Err_lb.Text = "User already have this speciality";
            }
            else if (this.SpecsVal_lb.Text.Equals(string.Empty))
            {
                this.Err_lb.Text = string.Empty;
                this.SpecsVal_lb.Text += $"{this.Specs_cb.SelectedItem}";
            }
            else
            {
                this.Err_lb.Text = string.Empty;
                this.SpecsVal_lb.Text += $",{this.Specs_cb.SelectedItem}";
            }

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            List<string> strings = this.SpecsVal_lb.Text.Split(',').AsList();
            this.SpecsVal_lb.Text = string.Empty;
            strings.Remove(this.Specs_cb.SelectedItem.ToString());
            foreach (string s in strings)
            {
                if (strings.IndexOf(s) == 0) this.SpecsVal_lb.Text += s;
                else this.SpecsVal_lb.Text += $",{s}";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ServiceWindow parent = this.Parent.Parent as ServiceWindow;
            DefaultData();
            parent.RenderSpecManagement(sender, e);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Err_lb.Text = string.Empty;
            ServiceWindow parent = this.Parent.Parent as ServiceWindow;

            List<string> strings = this.SpecsVal_lb.Text.Split(',').AsList();

            using (SqlConnection conn = new SqlConnection(parent.connection))
            {
                conn.Open();
                conn.Execute("DELETE FROM [EmployeeSpecialities] WHERE UserId = @Id", new
                {
                    Id = int.Parse(this.Id_lb.Text)
                });
                foreach (string s in strings)
                {
                    conn.Execute("INSERT INTO [EmployeeSpecialities] ([UserID],[SpecialityID]) VALUES (@Id, @SpecialityID)", new
                    {
                        Id = int.Parse(this.Id_lb.Text),
                        SpecialityID = parent.specs.First(spec => spec.Speciality.Equals(s)).Id
                    });
                }

                this.Err_lb.ForeColor = Color.Green;
                this.Err_lb.Text = "Specialities updated";
            }
            DefaultData();
            parent.RenderSpecManagement(sender, e);
        }
    }
}
