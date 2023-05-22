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
        public int ModelId { get; set; }
        public int UserId { get; set; }
        public string VRN { get; set; }

        public Cars(int id, string vrn, int modelId, int userId)
        {
            Id = id;
            ModelId = modelId;
            UserId = userId;
            VRN = vrn;
        }
    }
}
