using Ebus.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebus.Core.Entities.Base
{
    public class Line : FullAuditedEntity
    {
        public Line()
        {
            LineStations = new List<LineStation>();
        }
        public string LineCode { get; set; }
        public string Name { get; set; }
        public string DhoneticAlphabet { get; set; }
        public string StartStation { get; set; }
        public string EndStation { get; set; }
        public List<LineStation> LineStations { get; set; }
        


    }
}
