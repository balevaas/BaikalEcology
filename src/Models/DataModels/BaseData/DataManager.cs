using BaseData.Repositories;
using System;
using System.IO;
using BaseData.DataProviders.EntityFramework.Base.Repositories;
using BaseData.DataProviders.EntityFramework.Contexts;
using static ConnectionConfig.ConnectionStrings;

namespace BaseData;

public class DataManager
{
    public IHarmSubstance HarmSubstanceRep { get; }
    public IMonitoring MonitoringRep { get; }
    public IMonitoringType MonitoringTypeRep { get; }
    public IPoint PointRep { get; }
    public IPollutionField PollutionFieldRep { get; }
    public IPost PostRep { get; }
    public ISoftModule SoftModuleRep { get; }

    private DataManager(DataContext context)
    {
        //HarmSubstanceRep = context.HarmSubstances;
        //MonitoringRep = monitoringRep;
        //MonitoringTypeRep = monitoringTypeRep;
        //PointRep = pointRep;
        //PollutionFieldRep = pollutionFieldRep;
        //PostRep = postRep;
        //SoftModuleRep = softModuleRep;
    }

    //public static DataManager Get(DataProvider dataProvider)
    //{
    //    switch (dataProvider)
    //    {
    //        case DataProvider.SqlServer:
    //            var dir = Path.GetDirectoryName(GetConnectionStrings(SqlExpress));
    //            if (!Directory.Exists(dir))
    //            {
    //                Directory.CreateDirectory(dir!);
    //            }
    //            var context = new SqlServerDbContext();
    //            context.Database.EnsureCreated();
    //            return new DataManager
    //            (
    //                new HarmSubstanceRep(context),
    //                new MonitoringRep(context),
    //                new MonitoringTypeRep(context),
    //                new PointRep(context),
    //                new PollutionFieldRep(context),
    //                new PostRep(context),
    //                new SoftModuleRep(context)
    //            );

    //        case DataProvider.SqLite:
    //            throw new NotImplementedException("В работе");
    //        default: throw new NotImplementedException("Ошибка");
    //    }
    //}
}