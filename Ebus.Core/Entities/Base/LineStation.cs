using Ebus.Core.Entities.Stations;
using Ebus.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ebus.Core.Entities.Base
{
    public class LineStation : FullAuditedEntity
    {
        
        public int LineId { get; set; }
        public Line Line { get; set; }
       
        public int StationId{get;set;}
        public  Station Station { get; set; }
    }
}
