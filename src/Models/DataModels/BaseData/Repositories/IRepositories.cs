using BaseData.Entities;

namespace BaseData.Repositories
{
    public interface IHarmSubstance : IRepositoryBase<HarmSubstance> { }
    public interface IMonitoring : IRepositoryBase<Monitoring> { }
    public interface IMonitoringType : IRepositoryBase<MonitoringType> { }
    public interface IPollutionField : IRepositoryBase<PollutionField> { }
    public interface ISoftModule : IRepositoryBase<SoftModule> { }
}
