using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtCaseAgnt
    {
        public int CaseId { get; set; }
        public int AgntSeqRecNum { get; set; }
        public string FaName { get; set; }
        public string FaPhone { get; set; }
        public string FaEmail { get; set; }
        public string FaAsstname { get; set; }
        public string FaAsstEmail { get; set; }
        public string FaAsstPhone { get; set; }
        public string FaFirmRegion { get; set; }
        public string FaNpn { get; set; }
        public string FaBusinessStreet1 { get; set; }
        public string FaBusinessStreet2 { get; set; }
        public string FaBusinessCity { get; set; }
        public string FaBusinessState { get; set; }
        public string FaBusinessZipCode { get; set; }
        public string FaBusinessCountry { get; set; }
        public decimal? FaLatitude { get; set; }
        public decimal? FaLongtitude { get; set; }
        public string FaPosition { get; set; }
        public string FaSlContactId { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public virtual DmtCase Case { get; set; }
    }
}
