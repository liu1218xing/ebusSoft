using Ebus.Core.Entities.Stations;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebus.EntityFrameworkCore.EntityFrameworkCore
{
    public class MyContextSeed
    {
        public static async Task SeedAsync(EbusDbContext ebusDbContext,
                          ILoggerFactory loggerFactory, int retry = 0)
        {
            int retryForAvailability = retry;
            try
            {
                if (!ebusDbContext.Stations.Any())
                {
                    ebusDbContext.Stations.AddRange(
                        new List<Station>
                        {
                            new Station
                            {
                                 Name="深圳",
                                 Code="4402",
                                 DisplayName="深圳"
                            },
                            new Station
                            {
                                 Name="广州",
                                 Code="4401",
                                 DisplayName="广州"
                            }
                        }
                        );
                    await ebusDbContext.SaveChangesAsync();
                }
            }catch(Exception ex)
            {
                if (retryForAvailability < 10)
                {
                    retryForAvailability++;
                    var logger = loggerFactory.CreateLogger<MyContextSeed>();
                    logger.LogError(ex.Message);
                    await SeedAsync(ebusDbContext, loggerFactory, retryForAvailability);
                }
            }
        }
    }
}
