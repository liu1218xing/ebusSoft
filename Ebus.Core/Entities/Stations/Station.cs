using Ebus.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ebus.Core.Entities.Base;

namespace Ebus.Core.Entities.Stations
{
    public class Station : FullAuditedEntity
    {
        public Station()
        {
            LineStations = new List<LineStation>();
        }
        //
        // 摘要:
        //     Maximum length of the Abp.Application.Editions.Edition.Name property.
        public const int MaxNameLength = 32;
        //
        // 摘要:
        //     Maximum length of the Abp.Application.Editions.Edition.Name property.
        public const int MaxDisplayNameLength = 64;

        //
        // 摘要:
        //     Unique name of this edition.
        [Required]
        [StringLength(32)]
        public string Code { get; set; }
        [Required]
        [StringLength(32)]
        public  string Name { get; set; }
        //
        // 摘要:
        //     Display name of this edition.
        [Required]
        [StringLength(64)]
        public  string DisplayName { get; set; }
        public string DhoneticAlphabet { get; set; }
        public string Address { get; set; }
        public string ArrivalTime { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public List<LineStation> LineStations { get; set; }



    }
}
