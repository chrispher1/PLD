using System;
using System.Collections.Generic;

namespace PLD.WebApi.Angular.Models
{
    public partial class DmtValMap
    {
        public string SrcName { get; set; }
        public string SrcVal { get; set; }
        public string TrgtName { get; set; }
        public string TrgtVal { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }
    }
}
