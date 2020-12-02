using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chinook.Contracts.Persistence;
using Chinook.Contracts.Report.Marketing;
namespace Chinook.Report.Marketing.Models
{
    public class TrackInfo : ITrackInfo
    {
        public ITrack longest { get; set; }
        public ITrack shortest { get; set; }
        public long avgTime { get; set; }


       
    }
}
