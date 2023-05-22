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
        public int ModelId { get; set; }
        public string Part { get; set; }
        public float Price { get; set; }

        public Parts(int id, int modelId, string part, float price)
        {
            Id = id;
            ModelId = modelId;
            Part = part;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Part}";
        }
    }
}
