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
        public bool? ProdRtInd { get; set; }
        public bool? ProdTypRtInd { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public DmtCarr Carr { get; set; }
        public DmtProdTyp ProdTyp { get; set; }
        public ICollection<DmtCase> DmtCase { get; set; }
        public ICollection<DmtCaseHist> DmtCaseHist { get; set; }
        public ICollection<DmtComm> DmtComm { get; set; }
        public ICollection<DmtCommErr> DmtCommErr { get; set; }
        public ICollection<DmtProdAltName> DmtProdAltName { get; set; }
        public ICollection<DmtProdFbga> DmtProdFbga { get; set; }
        public ICollection<DmtProdRt> DmtProdRt { get; set; }
    }
}
