using BaseData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BaseData.DataProviders.Ef.Contexts;
using BaseData.DataProviders.Ef.Base.Repositories;

namespace BaseData
{
    public class DataManager
    {
        public IUserRep UserRep { get; }
        public IPollutionRep PolutionRep { get; }
        public IPointRep PointRep { get; }
        public IPollutionSetRep PolutionSetRep { get; }
        public IWindRoseRep WindRoseRep { get; }

        private DataManager(IUserRep userRep, IPollutionRep pollutionRep, IPointRep pointRep, IPollutionSetRep pollutionSetRep)
        {
            UserRep = userRep;
            PollutionRep = pollutionRep;
            PointRep = pointRep;
            PollutionSetRep = pollutionSetRep;
        }

        public static DataManager Get(DataProvider dataProvider)
        {
            switch (dataProvider)
            {
                case DataProvider.Sqlite:
                    var dir = Path.GetDirectoryName(SqLiteDbContext.DataSource);
                    if(!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir!);
                    }
                    var context = new SqLiteDbContext();
                    context.Database.EnsureCreated();
                    return new DataManager
                    (
                        new UserRep(context),
                        new PollutionRep(context),
                        new PointRep(context),
                        new PollutionSetRep(context)
                    );

                case DataProvider.SqlServer:
                case DataProvider.Oracle:
                case DataProvider.MySql:
                    throw new NotImplementedException("В работе");
                default: throw new NotImplementedException("Ошибка");
            }
        } 
    }
}
