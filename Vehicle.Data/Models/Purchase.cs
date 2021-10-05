using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Data.Models
{
    public class Purchase
    {
        public Int64 Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public DateTime DOB { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string RegistrationNumber { get; set; }
        public string BodyType { get; set; }
        public int Amount { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
