using Dapper;
using StationExam.Models;
using StationExam.Models.Essentials;
using System.Data.SqlClient;

namespace StationExam
{
    public partial class LoginForm : Form
    {
        private string connection = "Server=localhost\\SQLEXPRESS;Database=Station;Trusted_Connection=True;TrustServerCertificate=True;";
        List<Users> users = new List<Users>();
        public LoginForm()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    users = conn.Query<Users>("SELECT Users.Id, Users.Name, Roles.Role, Logins.Login, Passwords.Password " +
                        "FROM Users " +
                        "JOIN Roles ON Users.Id = Roles.Id " +
                        "JOIN Logins ON Users.Id = Logins.Id " +
                        "JOIN Passwords ON Users.Id = Passwords.Id").ToList();
                }
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = users.FindIndex(x => x.Login.Equals(this.Login_tb.Text));
            if (index < 0 || !users[index].Password.Equals(this.Password_tb.Text))
            {
                this.LoginErr_lb.Text = "Error";
                this.PasswordErr_lb.Text = "Error";
            }
            else
            {
                this.LoginErr_lb.Text = string.Empty;
                this.PasswordErr_lb.Text = string.Empty;
            }
        }
    }
}