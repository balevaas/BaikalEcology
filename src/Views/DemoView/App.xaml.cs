using System.Windows;
using BaseData.DataProviders.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using static ConnectionConfig.Strings;

namespace DemoView
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private DbContextFactory _context;

        public DataContext Context => _context.Create();

        public App()
        {
            
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var builder = new DbContextOptionsBuilder<DataContext>();
            builder.UseSqlServer(GetConnectionStrings(SqlExpress));

            this._context = new DbContextFactory(builder.Options);
        }
    }
}
