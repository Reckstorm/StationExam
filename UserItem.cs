using Dapper;
using Microsoft.VisualBasic.ApplicationServices;
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
                    conn.Execute("UPDATE [Users] SET Name = @Name, Role = @Role WHERE Id = @Id",
                        new { Name = this.Name_tb.Text, Role = parent.roles.FindIndex(x => x.Role.Equals(this.Role_cb.SelectedItem)) + 1, Id = int.Parse(this.Id_lb.Text) });
                    conn.Execute("UPDATE [Logins] SET Login = @Login WHERE Login = @OldLogin",
                        new { Login = this.Login_tb.Text, OldLogin = parent.users.Find(user => user.Id.Equals(this.Id_lb)).Login });
                    conn.Execute("UPDATE [Passwords] SET Password = @Password WHERE Password = @OldPassword",
                        new { Password = this.Password_tb.Text, OldPassword = parent.users.Find(user => user.Id.Equals(this.Id_lb)).Password });
                    this.Err_lb.ForeColor = Color.Green;
                    this.Err_lb.Text = "User updated";
                }
            }
            else
            {
                if (parent.users.Any(user => user.Login.Equals(this.Login_lb.Text)))
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

                    conn.Execute("INSERT INTO [Users] ([Name], [RoleID], [LoginID], [PasswordID]) VALUES (@Name, @Role, @Id, @Id)",
                        new
                        {
                            Id = int.Parse(this.Id_lb.Text),
                            Name = this.Name_tb.Text,
                            Role = parent.roles.FindIndex(x => x.Role.Equals(this.Role_cb.SelectedItem)) + 1,
                        });
                    this.Err_lb.ForeColor = Color.Green;
                    this.Err_lb.Text = "User created";
                }
            }
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
                    this.Err_lb.ForeColor = Color.Green;
                    this.Err_lb.Text = "User deleted";
                }
            }
            else
            {
                this.Err_lb.ForeColor = Color.Red;
                this.Err_lb.Text = "There is no such user";
            }
        }

        private void DefaultData(object sender, EventArgs e)
        {
            ServiceWindow parent = this.Parent.Parent as ServiceWindow;
            parent.roles.ForEach(role => this.Role_cb.Items.Add(role.Role));
            this.Id_lb.Text = (parent.users.Last().Id + 1).ToString();
            this.Err_lb.Text = string.Empty;
        }

    }
}
