using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Data.Models
{
    public class Purchase
    {
        [Key]
        public Int64 Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public DateTime DOB { get; set; }
        [Display(Name = "Make")]
        public string VehicleMake { get; set; }
        [Display(Name = "Model")]
        public string VehicleModel { get; set; }
        [Display(Name = "Reg Number")]
        public string RegistrationNumber { get; set; }
        [Display(Name = "Body Type")]
        public string BodyType { get; set; }
        public int Amount { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
