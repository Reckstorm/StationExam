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
        public int Id { get; set; }
        public Users User { get; set; }
        public Specialities Speciality { get; set; }

        public EmployeeSpecialities(int id, Users user, Specialities speciality)
        {
            Id = id;
            User = user;
            Speciality = speciality;
        }
    }
}
