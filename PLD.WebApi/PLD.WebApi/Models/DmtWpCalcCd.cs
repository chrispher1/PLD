using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtWpCalcCd
    {
        public string WpCalcCd { get; set; }
        public string DescTxt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }
    }
}
