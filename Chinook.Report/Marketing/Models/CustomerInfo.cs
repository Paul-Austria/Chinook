using Chinook.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Report.Marketing.Models
{
    public class CustomerInfo
    {
        public ICustomer maxCustomer { get; set; }
        public float maxSell { get; set; }

        public ICustomer minCustomer { get; set; }
        public float minSell { get; set; }

        public CustomerInfo(ICustomer max, float mf, ICustomer mC, float minf)
        {
            maxCustomer = max;
            maxSell = mf;
            minCustomer = mC;
            minSell = minf;
        }

    }
}
