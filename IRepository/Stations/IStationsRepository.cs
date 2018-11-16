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
        Task<Station> GetByIdAsync(int id);
        void Add(Station station);
        void Delete(Station station);
        void Update(Station station);
        
    }
}
