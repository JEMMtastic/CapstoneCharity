using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Domain.Entities;
using System.Data.Entity;

namespace Capstone.Domain.Concrete
{
    class CapstoneDbContext
    {
        DbSet<BvLocation> BvLocations { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Charity> Charities { get; set; }
        DbSet<PartnershipNight> PartnershipNights { get; set; }
        DbSet<StatsInfo> StatsInfos { get; set; }
    }
}
