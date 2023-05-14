using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseData.Entities;
using Microsoft.EntityFrameworkCore;

namespace BaseData.DataProviders.Ef.Base
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Pollution> Pollutions { get; set; } = null!;
        public DbSet<Point> Points { get; set; } = null!;
        public DbSet<PollutionSet> PollutionSets { get; set; } = null!;
        public DbSet<WindRoseHandler> WindRoseHandlers { get; set; } = null!;

        /*protected override void OnModelCreating(ModelBuilder mb)
        {

        }*/
    }
}
