using Chinook.Contracts.Persistence;
using Chinook.Report;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Chinook.Report.Marketing.Models;
using Chinook.Contracts.Report.Marketing;

namespace Chinook.Web.Controllers
{
    [Route("/reports/marketing")]
    [ApiController]
    public class MarketingStatisticsController : ControllerBase
    {
        private readonly ILogger<MarketingStatisticsController> _logger;

        public MarketingStatisticsController(ILogger<MarketingStatisticsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/reports/marketing/TrackOrderInfo")]
        public TrackOrderInfo TrackOrderInfo()
        {
            return MarketingReports.GetTrackOrderInfo();
        }


        [HttpGet("/reports/marketing/AlbumInfo")]
        public IAlbumInfo AlbumInfo()
        {
            return MarketingReports.GetAlbumInfo();
        }

        [HttpGet("/reports/marketing/TrackInfo")]
        public ITrackInfo GetTrackInfo()
        {
            return MarketingReports.GetTrackInfo();
        }

        [HttpGet("/reports/marketing/CustomerInfo")]
        public CustomerInfo CustomerInfo()
        {
            return MarketingReports.GetCustomerInfo();
        }

        [HttpGet("/reports/marketing/GenreInfo")]
        public GenreInfo GenreInfo()
        {
            return MarketingReports.GetGenreInfo();
        }
    }
}
