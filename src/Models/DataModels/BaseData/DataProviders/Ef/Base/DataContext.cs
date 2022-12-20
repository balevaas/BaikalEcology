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
        public DbSet<Polution> Polutions { get; set; } = null!;
        public DbSet<PolutionSet> PolutionSets { get; set; } = null!;

        /*protected override void OnModelCreating(ModelBuilder mb)
        {

        }*/
    }
}
