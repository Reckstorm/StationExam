using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationExam.Models
{
    internal class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public int LoginId { get; set; }
        public int PasswordId { get; set; }

        public Users(int id, string name, int roleId, int loginId, int passwordId)
        {
            Id = id;
            Name = name;
            RoleId = roleId;
            LoginId = loginId;
            PasswordId = passwordId;
        }
    }
}
