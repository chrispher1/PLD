using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtCal
    {
        public int CalId { get; set; }
        public string Name { get; set; }
        public string DescTxt { get; set; }
        public string CsrPrvdr { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }
    }
}
