using System;
using System.Collections.Generic;
using System.Text;
using Chinook.Contracts.Persistence;
namespace Chinook.Contracts.Report.Marketing
{
    public interface ITrackInfo
    {
        public ITrack longest { get; set; }
        public ITrack shortest { get; set; }
        public long avgTime { get; set; }
    }
}
