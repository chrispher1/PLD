using System;
using System.Collections.Generic;

namespace PLD.WebApi.Angular.Models
{
    public partial class DmtCusipProdMap
    {
        public string SndrId { get; set; }
        public string CusipNum { get; set; }
        public string CommOptCd { get; set; }
        public string CommExtCd { get; set; }
        public string ProdTypCd { get; set; }
        public int ProdId { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }
    }
}
