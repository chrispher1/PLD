using System;
using System.Collections.Generic;

namespace PLD.WebApi.Angular.Models
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

        public ICollection<DmtCarrFbga> DmtCarrFbga { get; set; }
        public ICollection<DmtCase> DmtCase { get; set; }
        public ICollection<DmtCaseHist> DmtCaseHist { get; set; }
        public ICollection<DmtCashRecon> DmtCashRecon { get; set; }
        public ICollection<DmtComm> DmtComm { get; set; }
        public ICollection<DmtCommErr> DmtCommErr { get; set; }
        public ICollection<DmtCommStmnt> DmtCommStmnt { get; set; }
        public ICollection<DmtPay> DmtPay { get; set; }
        public ICollection<DmtProd> DmtProd { get; set; }
        public ICollection<DmtProdTypRt> DmtProdTypRt { get; set; }
    }
}
