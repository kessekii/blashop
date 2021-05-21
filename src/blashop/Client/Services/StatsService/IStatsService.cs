using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blashop.Client.Services.StatsService
{
    interface IStatsService
    {
        Task GetVisits();
        Task IncrementVisits();
    }
}
