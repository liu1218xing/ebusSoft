using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IUnitOfWork
    {
        Task<bool> SaveAsync();
    }
}
