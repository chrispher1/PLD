using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PLD.WebApi.Angular.DTO;
using PLD.WebApi.Angular.Models;
namespace PLD.WebApi.Angular.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<DmtCommErr, CommissionErrorDTO>().ReverseMap();            
            CreateMap<DmtCarr, CarrierDTO>().ReverseMap();
            CreateMap<DmtProd, ProductDTO>().ReverseMap();
            CreateMap<DmtActCd, ActivityDTO>().ReverseMap();
            CreateMap<DmtStatCd, StatusDTO>().ReverseMap();
        }
    }
}
