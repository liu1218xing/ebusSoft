using Ebus.Core.Entities.Stations;
using Ebus.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebus.Core.Entities.Base
{
    public class City : FullAuditedEntity
    {
        public City()
        {
            Stations = new List<Station>();
        }
        public string Name { get; set; }
        public string AreaCode { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
        public List<Station> Stations { get; set; }
    }
}
