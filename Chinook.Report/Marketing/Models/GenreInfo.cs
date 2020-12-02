using Chinook.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Report.Marketing.Models
{
    public class GenreInfo
    {
        public IGenre maxGenre { get; set; }
        public int maxGenreCount { get; set; }

        public IGenre minGenre { get; set; }
        public int minGenreCount { get; set; }

        public GenreInfo(IGenre max, int maxI, IGenre min, int minI)
        {
            maxGenre = max;
            maxGenreCount = maxI;
            minGenre = min;
            minGenreCount = minI;
        }
    }
}
