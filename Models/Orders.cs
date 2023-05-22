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
        public int ServiceId { get; set; }
        public int PartId { get; set; }
        public int CarId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime DateTime { get; set; }

        public Orders(int id, int serviceId, int partId, int carId, int employeeId, DateTime dateTime)
        {
            Id = id;
            ServiceId = serviceId;
            PartId = partId;
            CarId = carId;
            EmployeeId = employeeId;
            DateTime = dateTime;
        }
    }
}
