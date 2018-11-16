using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ebus.Application.Shared.Stations;
using Ebus.Application.Shared.Stations.Dto;
using IRepository;
using IRepository.Stations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ebus.Web.Api.Controllers
{
    [Route("api/Stations")]
    public class StationsController : Controller
    {
        private readonly IStationAppService _stationAppService;
        private readonly IUnitOfWork _unitOfWork;

        public StationsController(IStationAppService stationAppService,
            IUnitOfWork unitOfWork)
        {
            _stationAppService = stationAppService;
            _unitOfWork = unitOfWork;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var stations = await _stationAppService.GetStations();
            return Ok(stations);
        }
        [AllowAnonymous]
        [HttpGet("{id}", Name = "GetPost")]
        public async Task<IActionResult> Get(int id)
        {
            var station = await _stationAppService.GetById(id);
            if(station == null)
            {
                return NotFound();
            }
            return Ok(station);
        }
        [HttpPost(Name = "CreatePost")]
        public async Task<IActionResult> Post([FromBody] CreateStationDto createStationDto)
        {
            if (createStationDto == null)
            {
                return BadRequest();
            }
            await _stationAppService.Create(createStationDto);

            return Ok();
        }

    }
}