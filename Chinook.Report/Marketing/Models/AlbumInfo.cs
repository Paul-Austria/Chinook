using System;
using System.Collections.Generic;
using System.Text;
using Chinook.Contracts.Persistence;
using Chinook.Contracts.Report.Marketing;

namespace Chinook.Report.Marketing.Models
{
    class AlbumInfo : IAlbumInfo
    {
        public object minTime { get; set; }
        public object maxTime { get; set; }
        public float avg { get; set; }
    }
}
