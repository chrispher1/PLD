﻿using System;
using System.Collections.Generic;

namespace PLD.Models
{
    public partial class DmtCaseWpRsvp
    {
        public int CaseWpRsvpId { get; set; }
        public int? CaseId { get; set; }
        public string RsvpStaffCd { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtById { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModById { get; set; }

        public virtual DmtCase Case { get; set; }
    }
}
