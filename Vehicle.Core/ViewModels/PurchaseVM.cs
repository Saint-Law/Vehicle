using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Core.ViewModels
{
    public class PurchaseVM
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


    public class CreatePurchaseVM
    {
        public Int64 Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public DateTime DOB { get; set; }

        //this will be used to populate a dropdown list from the database
        //instead of inputing it from the interface
        public IEnumerable<SelectListItem> VehicleMake { get; set; }
        public IEnumerable<SelectListItem> VehicleModel { get; set; }
        public IEnumerable<SelectListItem> BodyType { get; set; }
        public IEnumerable<SelectListItem> Amount { get; set; }


        public string RegistrationNumber { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
