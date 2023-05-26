using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationExam.Models.Essentials
{
    public class Logins
    {
        public int Id { get; set; }
        public string Login { get; set; }

        public Logins(int id, string login)
        {
            Id = id;
            Login = login;
        }

        public override string ToString()
        {
            return $"{Login}";
        }
    }
}
