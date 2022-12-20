using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseData.DataProviders.Ef.Base;
using Microsoft.EntityFrameworkCore;

namespace BaseData.DataProviders.Ef.Contexts
{
    public class SqLiteDbContext: DataContext
    {
        public const string DataSource = @"C:\Data\data.db";
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite($"Data Source = {DataSource}");
        }
    }
}
