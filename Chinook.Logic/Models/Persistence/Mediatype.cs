using CsvMapper.Logic.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Logic.Models.Persistence
{
    [DataClass(HasHeader = true, FileName = "CsvData/Mediatype.csv")]
    internal class Mediatype : IdentityObject, Contracts.Persistence.IMediaType
    {

        [DataPropertyInfo(OrderPosition = 1)]
        public string Name { get; set; }

    }
}
