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
        public string Service { get; set; }
        public Specialities Speciality { get; set; }
        public float Price { get; set; }

        public Services(int id, string service, Specialities speciality, float price)
        {
            Id = id;
            Service = service;
            Speciality = speciality;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Service}";
        }
    }
}
