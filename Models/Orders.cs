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
        public Services Service { get; set; }
        public Parts Part { get; set; }
        public Cars Car { get; set; }
        public Users Employee { get; set; }
        public DateTime DateTime { get; set; }

        public Orders(int id, Services service, Parts part, Cars car, Users employee, DateTime dateTime)
        {
            Id = id;
            Service = service;
            Part = part;
            Car = car;
            Employee = employee;
            DateTime = dateTime;
        }
    }
}
