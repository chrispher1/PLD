using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtCommStmnt
    {
        public DmtCommStmnt()
        {
            DmtCashReconStmnt = new HashSet<DmtCashReconStmnt>();
        }

        public int CommStmntId { get; set; }
        public int FbId { get; set; }
        public int GaId { get; set; }
        public int CarrId { get; set; }
        public string SrcFileName { get; set; }
        public string SndrId { get; set; }
        public DateTime ExtrctDt { get; set; }
        public int TotRecCnt { get; set; }
        public decimal SumPremAmt { get; set; }
        public decimal SumCommAmt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtById { get; set; }

        public DmtCarr Carr { get; set; }
        public DmtFb Fb { get; set; }
        public DmtGa Ga { get; set; }
        public ICollection<DmtCashReconStmnt> DmtCashReconStmnt { get; set; }
    }
}
