using BaseData.Entities;
using BaseData.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseData.DataProviders.Ef.Base.Repositories
{
    public class PollutionRep: IPollutionRep
    {
        private readonly DataContext Context;

        public PollutionRep(DataContext context)
        {
            Context = context;
        }

        public IQueryable<Pollution> Items => Context.Pollutions;

        public async Task<int> DeleteAsync(Pollution item)
        {
            if (Items.Contains(item))
            {
                Context.Remove(item);
                return await Context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<Pollution> GetItemByIdAsync(Guid id)
        {
            return await Items.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> UpdateAsync(Pollution item)
        {
            var rec = await Items.FirstOrDefaultAsync(x => x.Id == item.Id);
            if (rec != default) Context.Update(item);
            else await Context.AddAsync(item);
            return await Context.SaveChangesAsync();
        }
    }
}
