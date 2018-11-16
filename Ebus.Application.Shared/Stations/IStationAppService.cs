using Ebus.Application.Shared.Stations.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ebus.Application.Shared.Stations
{
    public interface IStationAppService
    {
        Task<List<StationListDto>> GetStations();
        Task<StationListDto> GetById(int id);
        Task<StationListDto> Create(CreateStationDto input);

    }
}
