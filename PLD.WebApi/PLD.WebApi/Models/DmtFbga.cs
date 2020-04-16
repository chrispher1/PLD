﻿using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtFbga
    {
        public int FbId { get; set; }
        public int GaId { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public DmtFb Fb { get; set; }
        public DmtGa Ga { get; set; }
    }
}