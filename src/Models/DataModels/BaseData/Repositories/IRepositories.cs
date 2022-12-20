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
    public interface IPolutionSetRep : IRepositoryBase<PolutionSet> { }
}
