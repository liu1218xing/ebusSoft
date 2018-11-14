using Ebus.Core.Entities.Stations;
using Ebus.EntityFrameworkCore.EntityFrameworkCore;
using IRepository.Stations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Stations
{
    public class StationsRepository : IStationsRepository
    {
        private readonly EbusDbContext _ebusDbContext;

        public StationsRepository(EbusDbContext ebusDbContext)
        {
            _ebusDbContext = ebusDbContext;
        }

        public void AddStations(Station station)
        {
            _ebusDbContext.Stations.Add(station);
        }

        public async Task<List<Station>> GetAllStationsAsync()
        {
            return await _ebusDbContext.Stations.ToListAsync();
            
        }
    }
}
