using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Data.Models
{
    public class BodyType
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Body Type")]
        public string bodyType { get; set; }
        public int Premium { get; set; }
    }
}
