using BaseData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseData.Repositories
{
    public interface IHarmSubstance : IRepositoryBase<HarmSubstance> { }
    public interface IMonitoring : IRepositoryBase<Monitoring> { }
    public interface IMonitoringType : IRepositoryBase<MonitoringType> { }
    public interface IPoint : IRepositoryBase<Point> { }
    public interface IPollutionField : IRepositoryBase<PollutionField> { }
    public interface IPost : IRepositoryBase<Post> { }
    public interface ISoftModule : IRepositoryBase<SoftModule> { }
}
