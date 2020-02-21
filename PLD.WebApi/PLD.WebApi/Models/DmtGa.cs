using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtGa
    {
        public DmtGa()
        {
            DmtCarrFbga = new HashSet<DmtCarrFbga>();
            DmtCase = new HashSet<DmtCase>();
            DmtCaseHist = new HashSet<DmtCaseHist>();
            DmtCashRecon = new HashSet<DmtCashRecon>();
            DmtComm = new HashSet<DmtComm>();
            DmtCommErr = new HashSet<DmtCommErr>();
            DmtCommStmnt = new HashSet<DmtCommStmnt>();
            DmtFbga = new HashSet<DmtFbga>();
            DmtPay = new HashSet<DmtPay>();
            DmtProdFbga = new HashSet<DmtProdFbga>();
        }

        public int GaId { get; set; }
        public string GaCd { get; set; }
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
        public ICollection<DmtFbga> DmtFbga { get; set; }
        public ICollection<DmtPay> DmtPay { get; set; }
        public ICollection<DmtProdFbga> DmtProdFbga { get; set; }
    }
}
