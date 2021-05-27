using System;
using System.Collections.Generic;

namespace PLD.Models
{
    public partial class DmtCarr
    {
        public DmtCarr()
        {            
            DmtCase = new HashSet<DmtCase>();    
            DmtCommErr = new HashSet<DmtCommErr>();            
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
        public virtual ICollection<DmtCase> DmtCase { get; set; }  
        public virtual ICollection<DmtComm> DmtComm { get; set; }
        public virtual ICollection<DmtCommErr> DmtCommErr { get; set; }        
        public virtual ICollection<DmtPay> DmtPay { get; set; }
        public virtual ICollection<DmtProd> DmtProd { get; set; }
        public virtual ICollection<DmtProdTypRt> DmtProdTypRt { get; set; }
    }
}
