using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationExam.Models
{
    public class Models
    {
        public int Id { get; set; }
        public string Model { get; set; }

        public Models(int id, string model)
        {
            Id = id;
            Model = model;
        }

        public override string ToString()
        {
            return $"{Model}";
        }
    }
}
