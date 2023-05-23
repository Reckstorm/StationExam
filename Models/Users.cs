using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StationExam.Models.Essentials;

namespace StationExam.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public Users()
        {
            Id = 0;
            Name = string.Empty;
            Role = string.Empty;
            Login = string.Empty;
            Password = string.Empty;
        }
        public Users(int id, string name, string role, string login, string password)
        {
            Id = id;
            Name = name;
            Role = role;
            Login = login;
            Password = password;
        }
    }
}
