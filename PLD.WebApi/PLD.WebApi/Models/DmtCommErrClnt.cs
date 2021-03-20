using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtCommErrClnt
    {
        public int CommId { get; set; }
        public int CommClntSeqNum { get; set; }
        public string ClntSsnTinNum { get; set; }
        public string ClntSsnTinTypCd { get; set; }
        public string ClntPrfxName { get; set; }
        public string ClntFirstName { get; set; }
        public string ClntMidName { get; set; }
        public string ClntLstName { get; set; }
        public string ClntSfxName { get; set; }
        public string ClntFullName { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtById { get; set; }
        public DateTime ModDt { get; set; }
        public string ModById { get; set; }
        public string SrcSsnTinTypCd { get; set; }

        public virtual DmtSsnTinTypCd ClntSsnTinTypCdNavigation { get; set; }
        public virtual DmtCommErr Comm { get; set; }
    }
}
