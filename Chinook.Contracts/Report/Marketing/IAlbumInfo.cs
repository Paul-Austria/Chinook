using System;
using System.Collections.Generic;
using System.Text;
using Chinook.Contracts.Persistence;

namespace Chinook.Contracts.Report.Marketing
{
    public interface IAlbumInfo
    {
        public object minTime { get; set; }

        public object maxTime { get; set; }
        public float avg { get; set; }
    }
}
