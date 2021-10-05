using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.Core.ViewModels;
using Vehicle.Data.Models;

namespace Vehicle.Core.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<BodyType, BodyTypeVM>().ReverseMap();
            CreateMap<Purchase, PurchaseVM>().ReverseMap();
            CreateMap<VehicleDetails, VehicleDetailsVM>().ReverseMap();
        }
    }
}
