using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PLD.DTO;
using PLD.Models;

namespace PLD.WebApi
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<DmtCommErr, CommissionErrorDTO>()
                .ForMember(errDto => errDto.ActCdNavigation,             
                commErr => commErr.MapFrom( commErr => commErr.Activity)
                )
                .ForMember(errDto => errDto.Carr,
                commErr => commErr.MapFrom( commErr => commErr.Carrier)
                )
                .ForMember( errDto => errDto.Prod,
                commErr => commErr.MapFrom ( commErr => commErr.Product)
                )
                .ForMember(
                    errDto => errDto.StatCdNavigation,
                    commErr => commErr.MapFrom( commErr => commErr.StatusCode)
                );

            CreateMap<CommissionErrorDTO, DmtCommErr>();
                        
            CreateMap<DmtComm, CommissionFinalDTO>()
                .ForMember(finalDto => finalDto.ActCdNavigation,             
                comm => comm.MapFrom( comm => comm.Activity)
                )
                .ForMember(finalDto => finalDto.Carr,
                comm => comm.MapFrom( comm => comm.Carrier)
                )
                .ForMember( finalDto => finalDto.Prod,
                comm => comm.MapFrom ( comm => comm.Product)
                )
                .ForMember(
                    finalDto => finalDto.StatCdNavigation,
                    comm => comm.MapFrom( comm => comm.StatusCode)
                );
           
            CreateMap<CommissionFinalDTO, DmtComm>();                          

            CreateMap<DmtComm, DmtCommErr>().ReverseMap();       

            CreateMap<DmtCarr, CarrierDTO>().ReverseMap();

            CreateMap<DmtProd, ProductDTO>().ReverseMap();

            CreateMap<DmtActCd, ActivityDTO>().ReverseMap();

            CreateMap<DmtStatCd, StatusDTO>().ReverseMap();
            CreateMap<DmtCommErr, CommissionDTO>()
                .ForMember(combine => combine.Carr,
                commErr => commErr.MapFrom( c => c.Carrier)            
                )
                .ForMember( combine => combine.Prod,
                comErr => comErr.MapFrom( c => c.Product)                            
                )
                .ForMember( combine => combine.ActCdNavigation,
                comErr => comErr.MapFrom( comErr => comErr.Activity)
                )
                .ForMember( combine => combine.StatCdNavigation,
                    comErr => comErr.MapFrom ( comErr => comErr.StatusCode)
                );

            CreateMap<DmtComm, CommissionDTO>()            
                .ForMember(combine => combine.Carr,
                comm => comm.MapFrom( c => c.Carrier)            
                )
                .ForMember( combine => combine.Prod,
                com => com.MapFrom( c => c.Product)                            
                )
                .ForMember( combine => combine.ActCdNavigation,
                com => com.MapFrom( com => com.Activity)
                )
                .ForMember( combine => combine.StatCdNavigation,
                    com => com.MapFrom ( com => com.StatusCode)
                );

        }
    }
}
