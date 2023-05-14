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
    public class WindRoseRep : IWindRoseRep
    {
        private readonly DataContext Context;

        public WindRoseRep(DataContext context)
        {
            Context = context;
        }
        public IQueryable<WindRoseHandler> Items => Context.WindRoseHandlers;

        public async Task<int> DeleteAsync(WindRoseHandler item)
        {
            if (Items.Contains(item))
            {
                Context.Remove(item);
                return await Context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<WindRoseHandler> GetItemByIdAsync(Guid id)
        {
            return await Items.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> UpdateAsync(WindRoseHandler item)
        {
            var rec = await Items.FirstOrDefaultAsync(x => x.Id == item.Id);
            if (rec != default) Context.Update(item);
            else await Context.AddAsync(item);
            return await Context.SaveChangesAsync();
        }
    }
}
