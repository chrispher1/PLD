using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtCarr
    {
        public DmtCarr()
        {
            DmtCarrFbga = new HashSet<DmtCarrFbga>();
            DmtCase = new HashSet<DmtCase>();
            DmtCaseHist = new HashSet<DmtCaseHist>();
            DmtCashRecon = new HashSet<DmtCashRecon>();
            DmtComm = new HashSet<DmtComm>();
            DmtCommErr = new HashSet<DmtCommErr>();
            DmtCommStmnt = new HashSet<DmtCommStmnt>();
            DmtPay = new HashSet<DmtPay>();
            DmtProd = new HashSet<DmtProd>();
            DmtProdTypRt = new HashSet<DmtProdTypRt>();
        }

        public int CarrId { get; set; }
        public string CarrCd { get; set; }
        public string Name { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public virtual ICollection<DmtCarrFbga> DmtCarrFbga { get; set; }
        public virtual ICollection<DmtCase> DmtCase { get; set; }
        public virtual ICollection<DmtCaseHist> DmtCaseHist { get; set; }
        public virtual ICollection<DmtCashRecon> DmtCashRecon { get; set; }
        public virtual ICollection<DmtComm> DmtComm { get; set; }
        public virtual ICollection<DmtCommErr> DmtCommErr { get; set; }
        public virtual ICollection<DmtCommStmnt> DmtCommStmnt { get; set; }
        public virtual ICollection<DmtPay> DmtPay { get; set; }
        public virtual ICollection<DmtProd> DmtProd { get; set; }
        public virtual ICollection<DmtProdTypRt> DmtProdTypRt { get; set; }
    }
}
