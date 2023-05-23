using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationExam.Models.Essentials
{
    public class Specialities
    {
        public int Id { get; set; }
        public string Speciality { get; set; }

        public Specialities(int id, string speciality)
        {
            Id = id;
            Speciality = speciality;
        }

        public override string ToString()
        {
            return $"{Speciality}";
        }
    }
}
