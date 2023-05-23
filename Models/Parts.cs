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
        public CarModels Model { get; set; }
        public string Part { get; set; }
        public float Price { get; set; }

        public Parts(int id, CarModels model, string part, float price)
        {
            Id = id;
            Model = model;
            Part = part;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Part}";
        }
    }
}
