using System;
using System.Collections.Generic;

namespace PLD.WebApi.Angular.Models
{
    public partial class DmtPay
    {
        public DmtPay()
        {
            DmtCashReconPay = new HashSet<DmtCashReconPay>();
            DmtPayCmnt = new HashSet<DmtPayCmnt>();
        }

        public int PayId { get; set; }
        public int FbId { get; set; }
        public int GaId { get; set; }
        public int CarrId { get; set; }
        public DateTime PayDt { get; set; }
        public string ChkWireNum { get; set; }
        public DateTime? DepDt { get; set; }
        public decimal EftOvrAmt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModById { get; set; }
        public bool? ValStmntInd { get; set; }
        public DateTime? ValStmntDt { get; set; }
        public string ValStmntById { get; set; }
        public DateTime? StmntId { get; set; }

        public DmtCarr Carr { get; set; }
        public DmtFb Fb { get; set; }
        public DmtGa Ga { get; set; }
        public ICollection<DmtCashReconPay> DmtCashReconPay { get; set; }
        public ICollection<DmtPayCmnt> DmtPayCmnt { get; set; }
    }
}
