using AutoMapper;
using Ebus.Application.Shared.Stations;
using Ebus.Application.Shared.Stations.Dto;
using Ebus.Core.Entities.Stations;
using IRepository.Stations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ebus.Application.Stations
{
    public class StationAppService : IStationAppService
    {
        private readonly IStationsRepository _stationsRepository;
        private readonly IMapper _mapper;

        public StationAppService(IStationsRepository stationsRepository, IMapper mapper)
        {
            _stationsRepository = stationsRepository;
            _mapper = mapper;
        }
        public async Task<List<StationListDto>> GetStations()
        {
            var stationList = await _stationsRepository.GetAllStationsAsync();
            var stationListDto = _mapper.Map<List<Station>, List<StationListDto>>(stationList);
            return stationListDto;
        }
    }
}
