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
    public class PolutionSetRep : IPolutionSetRep
    {
        private readonly DataContext Context;

        public PolutionSetRep(DataContext context)
        {
            Context = context;
        }

        public IQueryable<PolutionSet> Items => Context.PolutionSets;

        public async Task<int> DeleteAsync(PolutionSet item)
        {
            if(Items.Contains(item))
            {
                Context.Remove(item);
                return await Context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<PolutionSet> GetItemByIdAsync(Guid id)
        {
            return await Items.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> UpdateAsync(PolutionSet item)
        {
            var rec = await Items.FirstOrDefaultAsync(x => x.Id == item.Id);
            if (rec != default) Context.Update(item);
            else await Context.AddAsync(item);
            return await Context.SaveChangesAsync();
        }
    }
}
