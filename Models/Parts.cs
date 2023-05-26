using StationExam.Models.Essentials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationExam.Models
{
    public class Parts
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Part { get; set; }
        public float Price { get; set; }

        public Parts()
        {
            Id = 0;
            Model = string.Empty;
            Part = string.Empty;
            Price = 0;
        }

        public Parts(int id, string part, float price, string model)
        {
            Id = id;
            Model = model;
            Part = part;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Part} {Price}";
        }
    }
}
