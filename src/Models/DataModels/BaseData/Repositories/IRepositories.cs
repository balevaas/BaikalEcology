using BaseData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseData.Repositories
{
    public interface IUserRep : IRepositoryBase<User> { }
    public interface IPollutionRep : IRepositoryBase<Pollution> { }
    public interface IPointRep : IRepositoryBase<Point> { }
    public interface IWindRoseRep : IRepositoryBase<WindRoseHandler> { }
    public interface IPollutionSetRep : IRepositoryBase<PollutionSet>
    {
        public IQueryable<PollutionSet> GetPolutionsByDateAndPoint(DateTime time, Point point, Guid owner = default) =>
            Items.Where(i => i.Date == time &&
            i.Point.Latitude == point.Latitude && i.Point.Longitude == point.Longitude &&
            (owner == default || i.UserId == owner));
    }
}
