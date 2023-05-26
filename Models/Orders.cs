using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationExam.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int ServiceID { get; set; }
        public int PartID { get; set; }
        public int EmployeeID { get; set; }
        public string Car { get; set; }
        public DateTime DateTime { get; set; }

        public Orders(int id, int serviceId, int partId, string car, int employeeID, DateTime dateTime)
        {
            Id = id;
            ServiceID = serviceId;
            PartID = partId;
            Car = car;
            EmployeeID = employeeID;
            DateTime = dateTime;
        }

        public Orders()
        {
            Id = 0;
            ServiceID = 0;
            PartID = 0;
            EmployeeID = 0;
            Car = string.Empty;
            DateTime = DateTime.MinValue;
        }
    }
}
