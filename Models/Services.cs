using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationExam.Models
{
    public class Services
    {
        public int Id { get; set; }
        public string Service { get; set; }
        public string SpecialityId { get; set; }
        public float Price { get; set; }

        public Services(int id, string service, string specialityId, float price)
        {
            Id = id;
            Service = service;
            SpecialityId = specialityId;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Service}";
        }
    }
}
