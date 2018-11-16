using Ebus.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebus.Core.Entities.Base
{
    public class Province : FullAuditedEntity
    {
        public Province()
        {
            Cities = new List<City>();
        }
        public string Name { get; set; }
        public List<City> Cities { get; set; }
    }
}
