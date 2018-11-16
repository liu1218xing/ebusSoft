using AutoMapper;
using Ebus.Application.Shared.Stations;
using Ebus.Application.Shared.Stations.Dto;
using Ebus.Core.Entities.Stations;
using IRepository;
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
        private readonly IUnitOfWork _unitOfWork;

        public StationAppService(IStationsRepository stationsRepository
            ,IMapper mapper
            , IUnitOfWork unitOfWork)
        {
            _stationsRepository = stationsRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<StationListDto> Create(CreateStationDto input)
        {
            //var station = ObjectMapper.Map<User>(input);
            var station = _mapper.Map<CreateStationDto, Station>(input);
             _stationsRepository.Add(station);
            await _unitOfWork.SaveAsync();
            var result = _mapper.Map<Station, StationListDto>(station);
            return result;           
        }

        public async Task<StationListDto> GetById(int id)
        {
            var staion = await _stationsRepository.GetByIdAsync(id);
            var staionResource = _mapper.Map<Station, StationListDto>(staion);
            return staionResource;
        }

        public async Task<List<StationListDto>> GetStations()
        {
            var stationList = await _stationsRepository.GetAllStationsAsync();
            var stationListDto = _mapper.Map<List<Station>, List<StationListDto>>(stationList);
            return stationListDto;
        }
    }
}
