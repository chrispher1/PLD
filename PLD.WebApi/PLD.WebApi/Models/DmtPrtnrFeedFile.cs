using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtPrtnrFeedFile
    {
        public DmtPrtnrFeedFile()
        {
            DmtFeedFile = new HashSet<DmtFeedFile>();
        }

        public int PrtnrFeedFileId { get; set; }
        public int PrtnrFeedId { get; set; }
        public string Name { get; set; }
        public string DescTxt { get; set; }
        public string PathName { get; set; }
        public string FileNamePttrn { get; set; }
        public string FileNameExt { get; set; }
        public bool ReqdInd { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }
        public string TstInd { get; set; }

        public DmtPrtnrFeed PrtnrFeed { get; set; }
        public ICollection<DmtFeedFile> DmtFeedFile { get; set; }
    }
}
