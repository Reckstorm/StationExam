using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationExam.Models
{
    public class Passwords
    {
        public int Id { get; set; }
        public string Password { get; set; }

        public Passwords(int id, string password)
        {
            Id = id;
            Password = password;
        }

        public override string ToString()
        {
            return $"Password";
        }
    }
}
