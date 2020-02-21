using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtCalEntry
    {
        public int CalEntryId { get; set; }
        public int CalId { get; set; }
        public int? PrntCalEntryId { get; set; }
        public string SubjTxt { get; set; }
        public int? SubjRefId { get; set; }
        public DateTime StartDt { get; set; }
        public TimeSpan StartTm { get; set; }
        public DateTime EndDt { get; set; }
        public TimeSpan EndTm { get; set; }
        public string DescTxt { get; set; }
        public string RruleTxt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public DmtCalEntry CalEntry { get; set; }
        public DmtCalEntry InverseCalEntry { get; set; }
    }
}
