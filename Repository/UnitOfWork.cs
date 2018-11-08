using Ebus.EntityFrameworkCore.EntityFrameworkCore;
using IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EbusDbContext _ebusDbContext;

        public UnitOfWork(EbusDbContext ebusDbContext)
        {
            _ebusDbContext = ebusDbContext;
        }

        public async Task<bool> SaveAsync()
        {
            return await _ebusDbContext.SaveChangesAsync() > 0;
        }
    }
}
