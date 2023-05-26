using Dapper;
using Microsoft.VisualBasic.ApplicationServices;
using StationExam.Models;
using StationExam.Models.Essentials;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace StationExam
{
    public partial class ServiceWindow : Form
    {
        public Login login;
        public string connection = "Server=localhost\\SQLEXPRESS;Database=Station;Trusted_Connection=True;TrustServerCertificate=True;";
        public List<Users> users = new List<Users>();
        public List<Roles> roles = new List<Roles>();
        public List<Specialities> specs = new List<Specialities>();
        public List<CarModels> carModels = new List<CarModels>();
        public List<Cars> cars = new List<Cars>();
        public List<Parts> parts = new List<Parts>();
        public List<Services> services = new List<Services>();
        public List<Orders> orders = new List<Orders>();
        public Users currentUser;

        UserItem userItem = new UserItem();
        UserSpecControl userSpecControl = new UserSpecControl();
        UserCarControl userCarControl = new UserCarControl();
        OrderControl orderControl = new OrderControl();

        Panel left = new Panel();
        Panel right = new Panel();

        Label userName = new Label();
        Button logOut = new Button();

        Button manageUsers = new Button();
        Button manageSpecs = new Button();
        Button manageCars = new Button();
        Button manageOrders = new Button();
        public ServiceWindow()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                GetUsers();
                GetRoles();
                login = new Login() { Dock = DockStyle.Fill };
                this.Controls.Add(login);
            };
        }
        public void RenderUserUI(Users user)
        {
            OrderManagement(user);
            CarManagement();
            if (user.Role.Equals(roles[0].Role))
            {
                UserSpecManagement();
                UserManagement();
            }
        }
        public void LogOut(object sender, EventArgs e)
        {
            GetUsers();
            left.Controls.Clear();
            right.Controls.Clear();
            this.Controls.Clear();
            login = new Login() { Dock = DockStyle.Fill };
            this.Controls.Add(login);
        }
        public void OrderManagement(Users user)
        {
            #region Initialize Layout
            userName.Text = $"Hello {user.Name}";
            userName.Location = new Point(0, 0);
            userName.AutoSize = true;

            logOut.Text = "Logout";
            logOut.Height = 50;
            logOut.Width = 300;
            logOut.Location = new Point(0, this.Height - logOut.Height - 50);
            logOut.Click += LogOut;

            left.Location = new Point(0, 0);
            left.Width = 300;
            left.Height = this.Height - 50;
            left.BackColor = Color.LightGray;

            right.Location = new Point(left.Width, 0);
            right.BackColor = Color.SlateGray;
            right.Width = this.Width - left.Width - 20;
            right.Height = this.Height - 50;
            right.HorizontalScroll.Maximum = 0;
            right.AutoScroll = false;
            right.VerticalScroll.Visible = false;
            right.AutoScroll = true;

            left.Controls.Add(logOut);
            left.Controls.Add(userName);

            this.Controls.Add(left);
            this.Controls.Add(right);
            #endregion

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                parts = conn.Query<Parts>("SELECT Parts.Id, Parts.Part, Parts.Price, Models.Model " +
                    "FROM Parts " +
                    "JOIN Models ON Parts.ModelID = Models.Id").AsList();
                services = conn.Query<Services>("SELECT * FROM Services").AsList();
            }
            GetCars();

            orderControl.Location = new Point(0, 0);
            cars.ForEach(car => orderControl.Car_cb.Items.Add(car));
            services.ForEach(service => orderControl.Service_cb.Items.Add(service));


            manageOrders.Text = "Manage Orders";
            manageOrders.Height = 50;
            manageOrders.Width = 300;
            manageOrders.Location = new Point(0, userName.Location.Y + userName.Height + 30);
            manageOrders.Click += RenderOrderManagement;
            left.Controls.Add(manageOrders);
        }
        public void CarManagement()
        {
            GetModels();
            GetRoles();
            userCarControl.Location = new Point(0, 0);
            carModels.ForEach(model => userCarControl.Man_cb.Items.Add(model.ToString()));
            users.ForEach(user =>
            {
                if (user.Role.Equals(roles[1].Role)) userCarControl.User_cb.Items.Add(user.Name);
            });

            manageCars.Text = "Manage Cars";
            manageCars.Height = 50;
            manageCars.Width = 300;
            manageCars.Location = new Point(0, manageOrders.Location.Y + manageOrders.Height + 2);
            manageCars.Click += RenderCarManagement;
            left.Controls.Add(manageCars);
        }
        public void UserSpecManagement()
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                specs = conn.Query<Specialities>("SELECT * FROM Specialities").ToList();
            }

            userSpecControl.Location = new Point(0, 0);
            specs.ForEach(spec => userSpecControl.Specs_cb.Items.Add(spec.Speciality));

            manageSpecs.Text = "Manage Specs";
            manageSpecs.Height = 50;
            manageSpecs.Width = 300;
            manageSpecs.Location = new Point(0, manageCars.Location.Y + manageCars.Height + 2);
            manageSpecs.Click += RenderSpecManagement;
            left.Controls.Add(manageSpecs);
        }
        public void UserManagement()
        {
            userItem.Location = new Point(0, 0);
            roles.ForEach(role => userItem.Role_cb.Items.Add(role.Role));

            manageUsers.Text = "Manage Users";
            manageUsers.Height = 50;
            manageUsers.Width = 300;
            manageUsers.Location = new Point(0, manageSpecs.Location.Y + manageSpecs.Height + 2);
            manageUsers.Click += RenderUserManagement;
            left.Controls.Add(manageUsers);
        }
        public void GetUsers()
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                users = conn.Query<Users>("SELECT Users.Id, Users.Name, Roles.Role, Logins.Login, Passwords.Password " +
                    "FROM Users " +
                    "JOIN Roles ON Users.RoleID = Roles.Id " +
                    "JOIN Logins ON Users.Id = Logins.Id " +
                    "JOIN Passwords ON Users.Id = Passwords.Id").AsList();
            }
        }
        public void GetCars()
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                cars = conn.Query<Cars>("SELECT Cars.Id, Cars.VRN, Models.Model, Cars.UserID " +
                    "FROM Cars " +
                    "JOIN Models ON Cars.ModelID = Models.Id").AsList();
            }
        }
        public void GetModels()
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                carModels = conn.Query<CarModels>("SELECT * FROM Models").AsList();
            }
        }
        public void GetRoles()
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                roles = conn.Query<Roles>("SELECT * FROM ROLES").ToList();
            }
        }
        public void RenderUserManagement(object sender, EventArgs eventArgs)
        {
            right.Controls.Clear();
            GetUsers();
            right.Controls.Add(userItem);
            int y = userItem.Location.Y + userItem.Height + 2;
            users.ForEach(user =>
            {
                UserEntry temp = new UserEntry();
                temp.Id_lb.Text = user.Id.ToString();
                temp.NameVal_lb.Text = user.Name;
                temp.LoginVal_lb.Text = user.Login;
                temp.RoleVal_lb.Text = user.Role;
                temp.Location = new Point(0, y);
                temp.Click += (s, e) => userItem.SetUserEntry(temp);
                right.Controls.Add(temp);
                y += temp.Height + 2;
            });
        }
        public void RenderSpecManagement(object sender, EventArgs eventArgs)
        {
            right.Controls.Clear();
            GetUsers();
            right.Controls.Add(userSpecControl);
            int y = userSpecControl.Location.Y + userSpecControl.Height + 2;
            users.ForEach(user =>
            {
                if (user.Role == roles[2].Role)
                {
                    List<EmployeeSpecialities> tempSpecs = new List<EmployeeSpecialities>();
                    string specStr = string.Empty;
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();
                        tempSpecs = conn.Query<EmployeeSpecialities>("SELECT Specialities.Speciality, Users.Id " +
                            "FROM Specialities " +
                            "JOIN EmployeeSpecialities ON Specialities.Id = EmployeeSpecialities.SpecialityId " +
                            "JOIN Users ON EmployeeSpecialities.UserId = Users.Id " +
                            "WHERE Users.Id = @Id", new { Id = user.Id }).AsList();
                    }
                    foreach (EmployeeSpecialities spec in tempSpecs)
                    {
                        if (tempSpecs.IndexOf(spec) == 0) specStr += spec.ToString();
                        else specStr += $",{spec.ToString()}";
                    }


                    UserSpecEntry temp = new UserSpecEntry();
                    temp.Id_lb.Text = user.Id.ToString();
                    temp.NameVal_lb.Text = user.Name;
                    temp.SpecVal_lb.Text = specStr;
                    temp.Location = new Point(0, y);
                    temp.Click += (s, e) => userSpecControl.SetUserSpecEntry(temp);
                    right.Controls.Add(temp);
                    y += temp.Height + 2;
                }
            });
        }
        public void RenderCarManagement(object sender, EventArgs eventArgs)
        {
            GetCars();
            right.Controls.Clear();
            right.Controls.Add(userCarControl);
            int y = userCarControl.Location.Y + userCarControl.Height + 2;
            cars.ForEach(car =>
            {
                UserCarEntry temp = new UserCarEntry();
                temp.Id_lb.Text = car.Id.ToString();
                temp.ManVal_lb.Text = car.Model;
                temp.OwnerVal_lb.Text = users.Find(user => user.Id.Equals(car.UserId)).Name;
                temp.VRNVal_lb.Text = car.VRN;
                temp.Location = new Point(0, y);
                temp.Click += (s, e) => userCarControl.SetCarEntry(temp);
                right.Controls.Add(temp);
                y += temp.Height + 2;
            });
        }
        public void RenderOrderManagement(object sender, EventArgs eventArgs)
        {
            GetCars();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                orders = conn.Query<Orders>("SELECT * FROM Orders").AsList();
            }

            right.Controls.Clear();
            right.Controls.Add(orderControl);
            int y = orderControl.Location.Y + orderControl.Height + 2;
            orders.ForEach(order =>
            {
                OrderEntry temp = new OrderEntry();
                Services tmpSrv = services.Find(service => service.Id.Equals(order.ServiceID));
                Parts tmpPrt = parts.Find(part => part.Id.Equals(order.PartID));

                temp.Id_lb.Text = order.Id.ToString();
                temp.CarVal_lb.Text = order.Car;
                temp.EmpVal_lb.Text = users.Find(user => user.Id.Equals(order.EmployeeID)).Name;
                temp.Date_dp.Value = order.DateTime;
                temp.ServiceVal_lb.Text = tmpSrv.ToString();
                temp.PartVal_lb.Text = tmpPrt.ToString();
                temp.TotalVal_lb.Text = (tmpPrt.Price + tmpSrv.Price).ToString();
                temp.Location = new Point(0, y);
                temp.Click += (s, e) => orderControl.SetOrderEntry(temp);
                right.Controls.Add(temp);
                y += temp.Height + 2;
            });
        }
    }
}