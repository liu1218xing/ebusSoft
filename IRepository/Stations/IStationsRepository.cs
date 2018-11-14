using Ebus.Core.Entities.Stations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IRepository.Stations
{
    public interface IStationsRepository
    {
        Task<List<Station>> GetAllStationsAsync();
        void AddStations(Station station);
    }
}
