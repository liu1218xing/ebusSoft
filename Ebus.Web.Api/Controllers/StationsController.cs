using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IRepository;
using IRepository.Stations;
using Microsoft.AspNetCore.Mvc;

namespace Ebus.Web.Api.Controllers
{
    [Route("api/Stations")]
    public class StationsController : Controller
    {
        private readonly IStationsRepository _stationsRepository;
        private readonly IUnitOfWork _unitOfWork;

        public StationsController(IStationsRepository stationsRepository,
            IUnitOfWork unitOfWork)
        {
            _stationsRepository = stationsRepository;
            _unitOfWork = unitOfWork;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var stations = await _stationsRepository.GetAllStationsAsync();
            return Ok(stations);
        }

    }
}