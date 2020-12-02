using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

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

        [HttpGet("/reports/marketing/AlbumTimeStatistic")]
        public Contracts.Reports.Marketing.IAlbumTimeStatistic AlbumTime()
        {
            return Reports.Marketing.Reports.GetAlbumTimeStatistic();
        }

        [HttpGet("/reports/marketing/CostumerSaleStatistic")]
        public Contracts.Reports.Marketing.ICostumerSaleStatistic CostumerSale()
        {
            return Reports.Marketing.Reports.GetCostumerSaleStatistic();
        }

        [HttpGet("/reports/marketing/TrackSaleStatistic")]
        public Contracts.Reports.Marketing.ITrackSaleStatistic TrackSale()
        {
            return Reports.Marketing.Reports.GetTrackSaleStatistic();
        }

        [HttpGet("/reports/marketing/TrackTimeStatistic")]
        public Contracts.Reports.Marketing.ITrackTimeStatistic TrackTime()
        {
            return Reports.Marketing.Reports.GetTrackTimeStatistic();
        }
    }
}
