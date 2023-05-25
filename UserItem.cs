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
    public partial class UserItem : UserControl
    {
        public UserItem()
        {
            InitializeComponent();
            Load += DefaultData;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Err_lb.Text = string.Empty;
            ServiceWindow parent = this.Parent.Parent as ServiceWindow;

            if (parent.users.Any(user => user.Id == int.Parse(this.Id_lb.Text)))
            {
                using (SqlConnection conn = new SqlConnection(parent.connection))
                {
                    conn.Open();
                    conn.Execute("UPDATE [Users] SET Name = @Name, RoleID = @Role WHERE Id = @Id",
                        new { Name = this.Name_tb.Text, Role = parent.roles.FindIndex(x => x.Role.Equals(this.Role_cb.SelectedItem)) + 1, Id = int.Parse(this.Id_lb.Text) });
                    conn.Execute("UPDATE [Logins] SET Login = @Login WHERE Login = @OldLogin",
                        new { Login = this.Login_tb.Text, OldLogin = parent.users.Find(user => user.Id.Equals(int.Parse(this.Id_lb.Text))).Login });
                    conn.Execute("UPDATE [Passwords] SET Password = @Password WHERE Password = @OldPassword",
                        new { Password = this.Password_tb.Text, OldPassword = parent.users.Find(user => user.Id.Equals(int.Parse(this.Id_lb.Text))).Password });
                    this.Err_lb.ForeColor = Color.Green;
                    this.Err_lb.Text = "User updated";
                }
            }
            else
            {
                if (parent.users.Any(user => user.Login.Equals(this.Login_tb.Text)))
                {
                    this.Err_lb.Text = "Login is already taken";
                    return;
                }
                using (SqlConnection conn = new SqlConnection(parent.connection))
                {
                    conn.Open();

                    conn.Execute("INSERT INTO [Logins] ([Login]) VALUES (@Login)",
                        new { Login = this.Login_tb.Text });

                    conn.Execute("INSERT INTO [Passwords] ([Password]) VALUES (@Password)",
                         new { Password = this.Password_tb.Text });

                    int LastID = conn.QuerySingle<Passwords>("SELECT TOP 1 * FROM Passwords ORDER BY ID DESC").Id;

                    conn.Execute("INSERT INTO [Users] ([Name], [RoleID], [LoginID], [PasswordID]) VALUES (@Name, @Role, @Id, @Id)",
                        new
                        {
                            Id = LastID,
                            Name = this.Name_tb.Text,
                            Role = parent.roles.FindIndex(x => x.Role.Equals(this.Role_cb.SelectedItem)) + 1
                        });
                    this.Err_lb.ForeColor = Color.Green;
                    this.Err_lb.Text = "User created";
                }
            }
            DefaultData(sender, e);
            parent.RenderUserManagement(sender, e);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.Err_lb.Text = string.Empty;
            ServiceWindow parent = this.Parent.Parent as ServiceWindow;

            if (parent.users.Any(user => user.Id == int.Parse(this.Id_lb.Text)))
            {
                using (SqlConnection conn = new SqlConnection(parent.connection))
                {
                    conn.Open();
                    conn.Execute("DELETE FROM [Users] WHERE Id = @Id", new { Id = int.Parse(this.Id_lb.Text) });
                    conn.Execute("DELETE FROM [Logins] WHERE Id = @Id", new { Id = int.Parse(this.Id_lb.Text) });
                    conn.Execute("DELETE FROM [Passwords] WHERE Id = @Id", new { Id = int.Parse(this.Id_lb.Text) });
                    conn.Execute("DELETE FROM [EmployeeSpecialities] WHERE Id = @Id", new { Id = int.Parse(this.Id_lb.Text) });
                    conn.Execute("DELETE FROM [Cars] WHERE UserID = @Id", new { Id = int.Parse(this.Id_lb.Text) });
                    this.Err_lb.ForeColor = Color.Green;
                    this.Err_lb.Text = "User deleted";
                }
            }
            else
            {
                this.Err_lb.ForeColor = Color.Red;
                this.Err_lb.Text = "There is no such user";
            }
            DefaultData(sender, e);
            parent.RenderUserManagement(sender, e);
        }

        private void DefaultData(object sender, EventArgs e)
        {
            ServiceWindow parent = this.Parent.Parent as ServiceWindow;
            this.Role_cb.SelectedItem = "Client";
            this.Id_lb.Text = (parent.users.Last().Id + 1).ToString();
            this.Err_lb.Text = string.Empty;
            this.Name_tb.Text = string.Empty;
            this.Login_tb.Text = string.Empty;
            this.Password_tb.Text = string.Empty;
        }

        public void SetUserEntry(UserEntry user)
        {
            ServiceWindow parent = this.Parent.Parent as ServiceWindow;
            this.Id_lb.Text = user.Id_lb.Text;
            this.Name_tb.Text = user.NameVal_lb.Text;
            this.Login_tb.Text = user.LoginVal_lb.Text;
            this.Password_tb.Text = parent.users.Find(user => user.Login.Equals(this.Login_tb.Text)).Password;
            this.Role_cb.SelectedItem = user.RoleVal_lb.Text;
        }
    }
}
