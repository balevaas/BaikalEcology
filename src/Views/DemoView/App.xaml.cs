using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using BaseData.DataProviders.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using static ConnectionConfig.ConnectionStrings;

namespace DemoView
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly DbContextFactory _context;

        public DataContext Context => _context.Create();

        public App()
        {
            var builder = new DbContextOptionsBuilder<DataContext>();
            builder.UseSqlServer(GetConnectionStrings(SqlExpress));

            this._context = new DbContextFactory(builder.Options);
        }
    }
}
