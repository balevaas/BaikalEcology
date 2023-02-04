using BaseData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseData.Repositories
{
    public interface IUserRep : IRepositoryBase<User> { }
    public interface IPolutionRep : IRepositoryBase<Polution> { }
    public interface IPointRep : IRepositoryBase<Point> { }
    public interface IPolutionSetRep : IRepositoryBase<PolutionSet>
    {
        public IQueryable<PolutionSet> GetPolutionsByDateAndPoint(DateTime time, Point point, Guid owner = default) =>
            Items.Where(i => i.Date == time &&
            i.Point.Latitude == point.Latitude && i.Point.Longitude == point.Longitude &&
            (owner == default || i.UserId == owner));
    }
}
