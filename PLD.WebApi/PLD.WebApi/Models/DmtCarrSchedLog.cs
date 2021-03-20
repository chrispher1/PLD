using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtCarrSchedLog
    {
        public int CarrId { get; set; }
        public int? CalEntryId { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
    }
}
