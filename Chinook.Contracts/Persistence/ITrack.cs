using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Persistence
{
    public interface ITrack : IIdentifiable
    {
        string Name { get; set; }
        int AlbumId { get; set; }
        int MediaTypeId { get; set; }
        int GenreId { get; set; }
        string Composer { get; set; }
        long Milliseconds { get; set; }
        long Bytes { get; set; }
        float UnitPrice { get; set; }
    }
}
