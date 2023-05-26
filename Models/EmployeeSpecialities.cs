using StationExam.Models.Essentials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationExam.Models
{
    public class EmployeeSpecialities
    {
        public int UserID { get; set; }
        public string Speciality { get; set; }

        public EmployeeSpecialities()
        {
            UserID = 0;
            Speciality = string.Empty;
        }
        public EmployeeSpecialities(string speciality, int userId)
        {
            UserID = userId;
            Speciality = speciality;
        }

        public override string ToString() 
        { 
            return Speciality;
        }
    }
}
