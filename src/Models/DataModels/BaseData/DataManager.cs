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
        public IPolutionRep PolutionRep { get; }
        public IPolutionSetRep PolutionSetRep { get; }

        private DataManager(IUserRep userRep, IPolutionRep polutionRep, IPolutionSetRep polutionSetRep)
        {
            UserRep = userRep;
            PolutionRep = polutionRep;
            PolutionSetRep = polutionSetRep;
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
                        new PolutionRep(context),
                        new PolutionSetRep(context)
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
