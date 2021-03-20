using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtProd
    {
        public DmtProd()
        {
            DmtCase = new HashSet<DmtCase>();
            DmtCaseHist = new HashSet<DmtCaseHist>();
            DmtComm = new HashSet<DmtComm>();
            DmtCommErr = new HashSet<DmtCommErr>();
            DmtProdAltName = new HashSet<DmtProdAltName>();
            DmtProdFbga = new HashSet<DmtProdFbga>();
            DmtProdRt = new HashSet<DmtProdRt>();
        }

        public int ProdId { get; set; }
        public int CarrId { get; set; }
        public int ProdTypId { get; set; }
        public string ProdCd { get; set; }
        public string Name { get; set; }
        public string Carrierid { get; set; }
        public string ProdRtInd { get; set; }
        public bool ProdTypRtInd { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public virtual DmtCarr Carr { get; set; }
        public virtual DmtProdTyp ProdTyp { get; set; }
        public virtual ICollection<DmtCase> DmtCase { get; set; }
        public virtual ICollection<DmtCaseHist> DmtCaseHist { get; set; }
        public virtual ICollection<DmtComm> DmtComm { get; set; }
        public virtual ICollection<DmtCommErr> DmtCommErr { get; set; }
        public virtual ICollection<DmtProdAltName> DmtProdAltName { get; set; }
        public virtual ICollection<DmtProdFbga> DmtProdFbga { get; set; }
        public virtual ICollection<DmtProdRt> DmtProdRt { get; set; }
    }
}
