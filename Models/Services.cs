using StationExam.Models.Essentials;
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
        public int SpecialityId { get; set; }
        public string Service { get; set; }
        public float Price { get; set; }

        public Services()
        {
            Id = 0;
            SpecialityId = 0;
            Service = string.Empty;
            Price = 0;
        }
        public Services(int id, string service, float price, int specialityId)
        {
            Id = id;
            Service = service;
            SpecialityId = specialityId;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Service} {Price}";
        }
    }
}
