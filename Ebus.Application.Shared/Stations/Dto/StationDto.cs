using Ebus.Application.Shared.Services.Dto;
using Ebus.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ebus.Application.Shared.Stations.Dto
{
    public class StationDto : EntityDto<long>
    {
        [Required]
        [StringLength(32)]
        public string Code { get; set; }
        [Required]
        [StringLength(32)]
        public string Name { get; set; }
        //
        // 摘要:
        //     Display name of this edition.
        [Required]
        [StringLength(64)]
        public string DisplayName { get; set; }
        public string DhoneticAlphabet { get; set; }
        public string Address { get; set; }
        public string ArrivalTime { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public List<LineStation> LineStations { get; set; }
    }
}
