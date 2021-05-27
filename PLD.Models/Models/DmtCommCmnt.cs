using System;
using System.Collections.Generic;

namespace PLD.Models
{
    public partial class DmtCommCmnt
    {
        public int CommCmntId { get; set; }
        public int CommId { get; set; }
        public string CmntTxt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
    }
}
