using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Core.ViewModels
{
    public class VehicleDetailsVM
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
