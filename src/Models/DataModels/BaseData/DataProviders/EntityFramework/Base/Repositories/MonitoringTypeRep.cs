using BaseData.Entities;
using BaseData.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseData.DataProviders.EntityFramework.Base.Repositories
{
    public class MonitoringTypeRep: IMonitoringType
    {
        private readonly DataContext Context;
        public MonitoringTypeRep(DataContext dataContext) => Context = dataContext;

        public IQueryable<MonitoringType> Items => (IQueryable<MonitoringType>)Context.Monitorings;

        public async Task<int> DeleteAsync(MonitoringType item)
        {
            if (Items.Contains(item))
            {
                Context.Remove(item);
                return await Context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<MonitoringType> GetItemByIdAsync(Guid id)
        {
            return await Items.FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<int> UpdateAsync(MonitoringType item)
        {
            var rec = await Items.FirstOrDefaultAsync(x => x.ID == item.ID);
            if (rec != default) Context.Update(item);
            else await Context.AddAsync(item);
            return await Context.SaveChangesAsync();
        }
    }
}
