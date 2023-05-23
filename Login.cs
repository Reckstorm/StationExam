using Microsoft.VisualBasic.ApplicationServices;
using StationExam.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationExam
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            ServiceWindow parent = this.Parent as ServiceWindow;
            parent.Close();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            ServiceWindow parent = this.Parent as ServiceWindow;
            int index = parent.users.FindIndex(x => x.Login.Equals(this.Login_tb.Text));
            if (index < 0 || !parent.users[index].Password.Equals(this.Password_tb.Text))
            {
                this.LoginErr_lb.Text = "Error";
                this.PasswordErr_lb.Text = "Error";
            }
            else
            {
                this.LoginErr_lb.Text = string.Empty;
                this.PasswordErr_lb.Text = string.Empty;
                parent.currentUser = parent.users[index];
                parent.RenderUserUI(parent.currentUser);
                this.Visible = false;
            }
        }
    }
}
