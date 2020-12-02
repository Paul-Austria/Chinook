using System;
using System.Collections.Generic;
using System.Text;
using Chinook.Contracts.Persistence;

namespace Chinook.Report.Marketing.Models
{
    public class TrackOrderInfo
    {
        public ITrack Maxtrack { get; set; }
        public int maxCount { get; set; }
        public float sellMax { get; set; }
        public ITrack minTrack { get; set; }
        public int minCount { get; set; }
        public float sellMin { get; set; }
        public TrackOrderInfo(ITrack t, int t1, float t2, ITrack t3, int t4, float t5)
        {
            Maxtrack = t;
            maxCount = t1;
            sellMax = t2;
            minTrack = t3;
            minCount = t4;
            sellMin = t5;
        }
    }
}
