using AutoMapper;
using Ebus.Application.Shared.Stations.Dto;
using Ebus.Core.Entities.Stations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ebus.Web.Api.AutoMapper
{
    public class CustomProfile:Profile
    {
        public CustomProfile()
        {
            CreateMap<Station, StationListDto>();

        }
    }
}
