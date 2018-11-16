
using Ebus.Application.Shared.Services.Dto;
using Ebus.Core.Entities.Base;
using Ebus.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebus.Application.Shared.Stations.Dto
{
    public class StationListDto:EntityDto, IHasCreationTime
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime CreationTime { get; set; }
        public City City { get; set; }
        public List<LineStation> LineStations { get; set; }
    }
}
