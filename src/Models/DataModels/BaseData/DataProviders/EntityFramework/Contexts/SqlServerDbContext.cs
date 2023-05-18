using BaseData.DataProviders.EntityFramework.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseData.DataProviders.EntityFramework.Contexts
{
    public class SqlServerDbContext : DataContext
    {
        public const string DataSource = @"Data Source=ANASTASIA-ПК\SQLEXPRESS;Initial Catalog=EcologyBaikalDB; Integrated Security=True;TrustServerCertificate=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"{DataSource}");
        }
    }
}
