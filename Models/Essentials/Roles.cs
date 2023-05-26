using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationExam.Models.Essentials
{
    public class Roles
    {
        public int Id { get; set; }
        public string Role { get; set; }

        public Roles(int id, string role)
        {
            Id = id;
            Role = role;
        }

        public override string ToString()
        {
            return $"{Role}";
        }
    }
}
