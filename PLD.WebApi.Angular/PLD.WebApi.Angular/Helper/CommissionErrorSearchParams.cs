namespace PLD.WebApi.Angular.Helper
{
    public class CommissionErrorSearchParams
    {
        public int? CarrId{ get; set; }
        public int? ProdId{ get; set; }
        public string PolNum{ get; set; }
        public int? YrNumMin{ get; set; }
        public int? YrNumMax{ get; set; }
        public string TmCd{ get; set; }
        public string ActCd{ get; set; }
        public decimal? GrsPremAmtMin { get; set; }
        public decimal? GrsPremAmtMax { get; set; }
        public decimal? CommPremAmtMin { get; set; }
        public decimal? CommPremAmtMax { get; set; }
        public decimal? CommRateMin { get; set; }
        public decimal? CommRateMax { get; set; }
        public decimal? CommAmtMin { get; set; }
        public decimal? CommAmtMax { get; set; }
        public string StatCd { get; set; }

    }
}