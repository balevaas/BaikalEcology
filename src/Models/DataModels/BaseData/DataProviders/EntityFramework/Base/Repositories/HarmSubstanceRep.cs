using BaseData.DataProviders.EntityFramework.Contexts;
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
    public class HarmSubstanceRep : IHarmSubstance
    {
        private readonly DataContext Context;
        public HarmSubstanceRep(DataContext dataContext) => Context = dataContext;
        
        public IQueryable<HarmSubstance> Items => Context.HarmSubstances;

        public async Task<int> DeleteAsync(HarmSubstance item)
        {
            if (Items.Contains(item))
            {
                Context.Remove(item);
                return await Context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<HarmSubstance> GetItemByIdAsync(int id)
        {
            return await Items.FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<int> UpdateAsync(HarmSubstance item)
        {
            var rec = await Items.FirstOrDefaultAsync(x => x.ID == item.ID);
            if (rec != default) Context.Update(item);
            else await Context.AddAsync(item);
            return await Context.SaveChangesAsync();
        }
    }
}
