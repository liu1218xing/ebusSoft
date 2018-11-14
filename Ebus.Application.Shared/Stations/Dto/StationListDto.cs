using Ebus.Application.Shared.Dto;
using Ebus.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebus.Application.Shared.Stations.Dto
{
    public class StationListDto:EntityDto, IHasCreationTime
    {
        public string Name { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
