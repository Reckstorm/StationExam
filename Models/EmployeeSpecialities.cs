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
        public int UserId { get; set; }
        public int SpecialityId { get; set; }

        public EmployeeSpecialities(int id, int userId, int specialityId)
        {
            Id = id;
            UserId = userId;
            SpecialityId = specialityId;
        }
    }
}
