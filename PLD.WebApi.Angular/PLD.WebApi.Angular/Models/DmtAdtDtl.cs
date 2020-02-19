using System;
using System.Collections.Generic;

namespace PLD.WebApi.Angular.Models
{
    public partial class DmtAdtDtl
    {
        public int AdtDtlId { get; set; }
        public int AdtId { get; set; }
        public string FldName { get; set; }
        public string OldVal { get; set; }
        public string NewVal { get; set; }

        public DmtAdt Adt { get; set; }
    }
}
