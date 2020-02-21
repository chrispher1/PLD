using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PLD.WebApi.DTO;
using PLD.WebApi.Models;

namespace PLD.WebApi.Helper
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
