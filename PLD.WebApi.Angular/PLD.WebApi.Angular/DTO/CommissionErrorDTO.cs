using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PLD.WebApi.Angular.DTO
{
    public class CommissionErrorDTO
    {
        public int CommId { get; set; }        
        public int? CarrId { get; set; }
        public int? ProdId { get; set; }        
        public string PolNum { get; set; }
        public int? YrNum { get; set; }
        public string TmCd { get; set; }
        public string ActCd { get; set; }
        public decimal? GrsPremAmt { get; set; }
        public decimal? CommPremAmt { get; set; }
        public decimal? CommRt { get; set; }
        public decimal? CommAmt { get; set; }               
        public string StatCd { get; set; }
        public DateTime? StatDt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtById { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModById { get; set; }
        public CarrierDTO Carr { get; set; }
        public ProductDTO Prod { get; set; }
        public ActivityDTO ActCdNavigation { get; set; }
        public StatusDTO StatCdNavigation { get; set; }

    }
}
