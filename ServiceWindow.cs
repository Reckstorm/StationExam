using Dapper;
using StationExam.Models;
using StationExam.Models.Essentials;
using System.Data.SqlClient;

namespace StationExam
{
    public partial class ServiceWindow : Form
    {
        public Login login;
        public string connection = "Server=localhost\\SQLEXPRESS;Database=Station;Trusted_Connection=True;TrustServerCertificate=True;";
        public List<Users> users = new List<Users>();
        public List<Roles> roles = new List<Roles>();
        public Users currentUser;

        UserItem userItem = new UserItem();

        Panel left = new Panel();
        Panel right = new Panel();

        Label userName = new Label();
        Button logOut = new Button();

        Button manageClients = new Button();
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
                login = new Login() { Dock = DockStyle.Fill };
                this.Controls.Add(login);
            };
        }

        public void RenderUserUI(Users user)
        {
            ClientManagement();
            OrderManagement(user);
        }

        public void EmployeeManagement()
        {

        }

        public void ClientManagement()
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                roles = conn.Query<Roles>("SELECT * FROM ROLES").ToList();
            }

            userItem.Location = new Point(0, 0);

            manageClients.Text = "Manage Clients";
            manageClients.Height = 50;
            manageClients.Dock = DockStyle.Top;
            manageClients.Click += (s, e) => right.Controls.Add(userItem);
            left.Controls.Add(manageClients);      
        }

        public void OrderManagement(Users user)
        {
            #region Initialize Layout
            userName.Text = $"Hello {user.Name}";
            userName.Dock = DockStyle.Top;

            logOut.Text = "Logout";
            logOut.Height = 50;
            logOut.Dock = DockStyle.Top;
            logOut.Click += (s, e) =>
            {
                this.Controls.Clear();
                login = new Login() { Dock = DockStyle.Fill };
                this.Controls.Add(login);
            };

            left.Location = new Point(0, 0);
            left.Width = 300;
            left.Height = this.Height - 50;
            left.BackColor = Color.LightGreen;

            right.Location = new Point(left.Width, 0);
            right.BackColor = Color.LightSkyBlue;
            right.Width = this.Width - left.Width - 20;
            right.Height = this.Height - 50;

            left.Controls.Add(logOut);
            left.Controls.Add(userName);

            this.Controls.Add(left);
            this.Controls.Add(right);
            #endregion
        }
    }
}