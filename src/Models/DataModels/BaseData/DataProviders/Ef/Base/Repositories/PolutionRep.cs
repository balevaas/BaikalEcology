using BaseData.Entities;
using BaseData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BaseData.DataProviders.Ef.Base.Repositories
{
    public class PolutionRep : IPolutionRep
    {
        private readonly DataContext Context;

        public PolutionRep(DataContext context)
        {
            Context = context;
        }

        public IQueryable<Polution> Items => Context.Polutions;

        public async Task<int> DeleteAsync(Polution item)
        {
            if(Items.Contains(item))
            {
                Context.Remove(item);
                return await Context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<Polution> GetItemByIdAsync(Guid id)
        {
            return await Items.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> UpdateAsync(Polution item)
        {
            var rec = await Items.FirstOrDefaultAsync(x => x.Id == item.Id);
            if (rec != default) Context.Update(item);
            else await Context.AddAsync(item);
            return await Context.SaveChangesAsync();
        }
    }
}
