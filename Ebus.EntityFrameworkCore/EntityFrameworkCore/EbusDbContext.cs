using Ebus.Core.Entities.Base;
using Ebus.Core.Entities.Stations;
using Ebus.Core.Entities.test;
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
            modelBuilder.Entity<LineStation>().HasOne(x => x.Line).WithMany(x => x.LineStations)
                .HasForeignKey(x => x.LineId);
            modelBuilder.Entity<LineStation>().HasOne(x => x.Station).WithMany(x => x.LineStations)
                .HasForeignKey(x => x.StationId);
            modelBuilder.Entity<Station>().HasOne(x => x.City).WithMany(x => x.Stations)
                .HasForeignKey(x => x.CityId);
            modelBuilder.Entity<City>().HasOne(x => x.Province).WithMany(x => x.Cities)
                .HasForeignKey(x => x.ProvinceId);
            //base.OnModelCreating(modelBuilder);
            
            //modelBuilder.ApplyConfiguration(new PostConfiguration());
            //modelBuilder.ApplyConfiguration(new PostImageConfiguration());
        }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Post> Posts { get; set; }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Line> Lines { get; set; }
        public DbSet<LineStation> LineStations { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }
    }
}
