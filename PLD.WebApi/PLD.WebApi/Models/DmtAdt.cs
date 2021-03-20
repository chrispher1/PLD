using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtAdt
    {
        public DmtAdt()
        {
            DmtAdtDtl = new HashSet<DmtAdtDtl>();
        }

        public int AdtId { get; set; }
        public string AdtTypCd { get; set; }
        public string SrcName { get; set; }
        public string TblName { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public string Pk1Id { get; set; }
        public string Pk2Id { get; set; }
        public string Pk3Id { get; set; }
        public string Pk4Id { get; set; }
        public string Pk5Id { get; set; }
        public string Pk6Id { get; set; }
        public string Pk7Id { get; set; }

        public virtual DmtAdtTypCd AdtTypCdNavigation { get; set; }
        public virtual ICollection<DmtAdtDtl> DmtAdtDtl { get; set; }
    }
}
