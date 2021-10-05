using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Data.Models
{
    public class BodyType
    {
        public int Id { get; set; }
        public string bodyType { get; set; }
        public int Premium { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
