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
        public CarModels Model { get; set; }
        public Users User { get; set; }
        public string VRN { get; set; }

        public Cars(int id, string vrn, CarModels model, Users user)
        {
            Id = id;
            Model = model;
            User = user;
            VRN = vrn;
        }
    }
}
