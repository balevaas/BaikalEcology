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
    public class UserRep : IUserRep
    {
        private readonly DataContext Context;

        public UserRep(DataContext context)
        {
            Context = context;
        }

        public IQueryable<User> Items => Context.Users;

        public async Task<int> DeleteAsync(User item)
        {
            if(Items.Contains(item))
            {
                Context.Remove(item);
                return await Context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<User> GetItemByIdAsync(Guid id)
        {
            return await Items.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> UpdateAsync(User item)
        {
            var rec = await Items.FirstOrDefaultAsync(x => x.Id == item.Id);
            if (rec != default) Context.Update(item);
            else await Context.AddAsync(item);
            return await Context.SaveChangesAsync();
        }
    }
}
