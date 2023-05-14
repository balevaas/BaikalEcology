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
    public class PollutionSetRep : IPollutionSetRep
    {
        private readonly DataContext Context;

        public PollutionSetRep(DataContext context)
        {
            Context = context;
        }

        public IQueryable<PollutionSet> Items => Context.PollutionSets;

        public async Task<int> DeleteAsync(PollutionSet item)
        {
            if (Items.Contains(item))
            {
                Context.Remove(item);
                return await Context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<PollutionSet> GetItemByIdAsync(Guid id)
        {
            return await Items.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> UpdateAsync(PollutionSet item)
        {
            item.WindRose = WindRoseHandler.GetCheckGrad(item.WindRose);
            var rec = await Items.FirstOrDefaultAsync(x => x.Id == item.Id);
            if (rec != default) Context.Update(item);
            else await Context.AddAsync(item);
            return await Context.SaveChangesAsync();
        }
    }      
}
