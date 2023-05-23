// Ignore Spelling: Monitorings

using BaseData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseData.DataProviders.EntityFramework.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<HarmSubstance> HarmSubstances { get; set; } = null!;
        public DbSet<Monitoring> Monitorings { get; set; } = null!;
        public DbSet<MonitoringType> MonitoringTypes { get; set; } = null!;
        public DbSet<Point> Points { get; set; } = null!;
        public DbSet<PollutionField> PollutionFields { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<SoftModule> SoftModules { get; set; } = null!;
    }
}
