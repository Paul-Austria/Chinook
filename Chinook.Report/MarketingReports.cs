using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chinook.Contracts.Persistence;
using Chinook.Contracts.Report.Marketing;
using Chinook.Report.Marketing.Models;

namespace Chinook.Report
{
	public class MarketingReports
	{
        
        public static TrackOrderInfo GetTrackOrderInfo()
        {
            var tracks = Logic.Factory.GetTracks();
            var invoiceLines = Logic.Factory.GetInvoiceLines();
            var quantity = (from il in invoiceLines
                            group il by il.TrackId into gr
                            select new
                            {
                                TrackId = gr.Key,
                                Quantity = gr.Sum(x => x.Quantity),
                                Price = gr.Sum(x => x.Quantity) * gr.Sum(x => x.UnitPrice)
                            });

            var t1 = quantity.OrderByDescending(c => c.Quantity).First();
            var t2 = quantity.OrderByDescending(c => c.Quantity).Last();
            ITrack maxT = tracks.FirstOrDefault(c => c.Id == t1.TrackId);
            ITrack minT = tracks.FirstOrDefault(c => c.Id == t2.TrackId);

            return new TrackOrderInfo(maxT, t1.Quantity, t1.Price, minT, t2.Quantity, t2.Price);
        }

        public static GenreInfo GetGenreInfo()
        {
            var tracks = Logic.Factory.GetTracks();
            var invoiceLines = Logic.Factory.GetInvoiceLines();
            var genres = Logic.Factory.GetAllGenres();

            var genreVerkauf = (from l in invoiceLines
                                join track in tracks on l.TrackId equals track.Id
                                join gr in genres
                                on track.GenreId equals gr.Id
                                group new { track, l, gr } by track.GenreId into g
                                select new
                                {
                                    GenreId = g.Key,
                                    Quantity = g.Sum(c => c.l.Quantity)
                                }).OrderByDescending(c => c.Quantity);


            var topGenre = genreVerkauf.First();
            var bottomGenre = genreVerkauf.Last();


            var tG = genres.FirstOrDefault(c => c.Id == topGenre.GenreId);
            var bG = genres.FirstOrDefault(c => c.Id == bottomGenre.GenreId);

            return new GenreInfo(tG, topGenre.Quantity, bG, bottomGenre.Quantity);
        }

        public static CustomerInfo GetCustomerInfo()
        {
            var invoiceLines = Logic.Factory.GetInvoiceLines();
            var invoices = Logic.Factory.GetInvoices();
            var customers = Logic.Factory.GetAllCustomers();

            var iLines = (from invoiceL in invoiceLines
                          group invoiceL by invoiceL.InvoiceId into ilGroup
                          select new
                          {
                              InvoiceId = ilGroup.Key,
                              Quantity = ilGroup.Sum(x => x.Quantity),
                              Price = ilGroup.Sum(x => x.Quantity) * ilGroup.Sum(x => x.UnitPrice)
                          }).OrderByDescending(c => c.Price);



            var top = iLines.First();
            var bottom = iLines.Last();

            var tI = invoices.FirstOrDefault(c => c.Id == top.InvoiceId);
            var bI = invoices.FirstOrDefault(c => c.Id == bottom.InvoiceId);

            ICustomer topC = customers.FirstOrDefault(c => c.Id == tI.CustomerId);
            ICustomer bC = customers.FirstOrDefault(c => c.Id == bI.CustomerId);

            return new CustomerInfo(topC, top.Price, bC, bottom.Price);
        }


		public static ITrackInfo GetTrackInfo()
        {
            var tracks = Logic.Factory.GetTracks();
            TrackInfo trackInfo = new TrackInfo();
            trackInfo.longest = tracks.Aggregate((a, b) => a.Milliseconds > b.Milliseconds ? a : b); ;

            trackInfo.longest = tracks.Aggregate((a, b) => a.Milliseconds < b.Milliseconds ? a : b);

            trackInfo.avgTime = (long)tracks.Average(tr => tr.Milliseconds);

            return trackInfo;
        }

        public static IAlbumInfo GetAlbumInfo()
        {
            AlbumInfo info = new AlbumInfo(); 
            var tracks = Logic.Factory.GetTracks();

            var nT = (from pl in tracks
                      group pl by pl.AlbumId into trackGroup
                      select new
                      {
                          AlbumId = trackGroup.Key,
                          Time = trackGroup.Sum(y => y.Milliseconds)
                      }).OrderByDescending(c => c.Time);

            info.minTime  = nT.Last();
            info.maxTime = nT.First();

            info.avg = (float)nT.Average(c => c.Time);

            return info;


        }
	}
}
