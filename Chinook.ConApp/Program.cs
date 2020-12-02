using System;
using Chinook.Logic;
using Chinook.Contracts.Report.Marketing;
using Chinook.Report;
namespace Chinook.ConApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Chinook-Marketing!");

			var genres = Logic.Factory.GetAllGenres();
			var artists = Logic.Factory.GetAllArtists();
			var albums = Logic.Factory.GetAllAlbums();
			var customer = Logic.Factory.GetAllCustomers();
			var employee = Logic.Factory.GetAllEmployees();
			var invoice = Logic.Factory.GetInvoices();
			var mediaType = Logic.Factory.GetAllMediaType();
			var playlist = Logic.Factory.GetPlaylists();
			var playlistTrack = Logic.Factory.GetPlaylistTracks();
			var track = Logic.Factory.GetTracks();


			var genreInfo = MarketingReports.GetGenreInfo();
			var TrackInfo = MarketingReports.GetTrackInfo();
			var albumInfo = MarketingReports.GetAlbumInfo();
			var customerInfo = MarketingReports.GetCustomerInfo();
			
			var trackOrderInfo = MarketingReports.GetTrackOrderInfo();
		}
	}
}
