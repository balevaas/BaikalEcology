// Ignore Spelling: Monitorings

using BaseData.Entities;
using Microsoft.EntityFrameworkCore;

namespace BaseData.DataProviders.EntityFramework.Contexts
{
    public sealed class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<HarmSubstance> HarmSubstances { get; set; } = null!;
        public DbSet<Monitoring> Monitorings { get; set; } = null!;
        public DbSet<MonitoringType> MonitoringTypes { get; set; } = null!;
        public DbSet<PollutionField> PollutionFields { get; set; } = null!;
        public DbSet<SoftModule> SoftModules { get; set; } = null!;

    }
}
