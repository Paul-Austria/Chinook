using System.Collections.Generic;

namespace Chinook.Logic
{
	public class Factory
	{
		public static IEnumerable<Contracts.Persistence.IGenre> GetAllGenres()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Genre>();

			return result;
		}
		public static IEnumerable<Contracts.Persistence.IArtist> GetAllArtists()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Artist>();

			return result;
		}
		public static IEnumerable<Contracts.Persistence.IAlbum> GetAllAlbums()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Album>();

			return result;
		}

		public static IEnumerable<Contracts.Persistence.IEmployee> GetAllEmployees()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Employee>();

			return result;
		}

		public static IEnumerable<Contracts.Persistence.ICustomer> GetAllCustomers()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Customer>();

			return result;
		}
		public static IEnumerable<Contracts.Persistence.IInvoiceLine> GetInvoiceLines()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.InvoiceLine>();

			return result;
		}

		public static IEnumerable<Contracts.Persistence.IInvoice> GetAllMediaType()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Invoice>();

			return result;
		}

		public static IEnumerable<Contracts.Persistence.IInvoice> GetInvoices()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Invoice>();

			return result;
		}

		public static IEnumerable<Contracts.Persistence.IPlaylist> GetPlaylists()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Playlist>();

			return result;
		}
		public static IEnumerable<Contracts.Persistence.IPlaylistTrack> GetPlaylistTracks()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.PlaylistTrack>();

			return result;
		}
		public static IEnumerable<Contracts.Persistence.ITrack> GetTracks()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Track>();

			return result;
		}



	}
}
