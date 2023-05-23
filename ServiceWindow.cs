using Dapper;
using StationExam.Models;
using StationExam.Models.Essentials;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace StationExam
{
    public partial class ServiceWindow : Form
    {
        public Login login = new Login() { Dock = DockStyle.Fill };
        public string connection = "Server=localhost\\SQLEXPRESS;Database=Station;Trusted_Connection=True;TrustServerCertificate=True;";
        public List<Users> users = new List<Users>();
        public Users currentUser;
        public ServiceWindow()
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
                this.Controls.Add(login);

            };
        }

        public void RenderUserUI(Users user)
        {

        }

        public void EmployeeManagement()
        {

        }

        public void ClientManagement()
        {

        }

        public void OrderManagement()
        {

        }
    }
}