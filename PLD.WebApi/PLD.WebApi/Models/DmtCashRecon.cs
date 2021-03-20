using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtCashRecon
    {
        public DmtCashRecon()
        {
            DmtCashReconCmnt = new HashSet<DmtCashReconCmnt>();
            DmtCashReconPay = new HashSet<DmtCashReconPay>();
            DmtCashReconStmnt = new HashSet<DmtCashReconStmnt>();
        }

        public int CashReconId { get; set; }
        public int FbId { get; set; }
        public int GaId { get; set; }
        public int CarrId { get; set; }
        public decimal? StmntSumAmt { get; set; }
        public decimal? PaySumAmt { get; set; }
        public decimal? BalAmt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtById { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModById { get; set; }
        public bool? AttstBalInd { get; set; }
        public DateTime? AttstBalDt { get; set; }
        public string AttstBalById { get; set; }

        public virtual DmtCarr Carr { get; set; }
        public virtual DmtFb Fb { get; set; }
        public virtual DmtGa Ga { get; set; }
        public virtual ICollection<DmtCashReconCmnt> DmtCashReconCmnt { get; set; }
        public virtual ICollection<DmtCashReconPay> DmtCashReconPay { get; set; }
        public virtual ICollection<DmtCashReconStmnt> DmtCashReconStmnt { get; set; }
    }
}
