using StationExam.Models.Essentials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationExam.Models
{
    public class Cars
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int UserId { get; set; }
        public string VRN { get; set; }

        public Cars()
        {
            Id = 0;
            Model = string.Empty;
            UserId = 0;
            VRN = string.Empty;
        }

        public Cars(int id, string vrn, string model, int user)
        {
            Id = id;
            Model = model;
            UserId = user;
            VRN = vrn;
        }
    }
}
