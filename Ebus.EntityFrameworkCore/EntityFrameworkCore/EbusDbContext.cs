using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebus.EntityFrameworkCore.EntityFrameworkCore
{
    public class EbusDbContext: DbContext
    {
        public EbusDbContext(DbContextOptions<EbusDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new PostConfiguration());
            //modelBuilder.ApplyConfiguration(new PostImageConfiguration());
        }

    }
}
