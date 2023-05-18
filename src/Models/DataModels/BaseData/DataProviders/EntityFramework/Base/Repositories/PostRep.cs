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
    public class PostRep : IPost
    {
        private readonly DataContext Context;
        public PostRep(DataContext dataContext) => Context = dataContext;

        public IQueryable<Post> Items => (IQueryable<Post>)Context.Posts;

        public async Task<int> DeleteAsync(Post item)
        {
            if (Items.Contains(item))
            {
                Context.Remove(item);
                return await Context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<Post> GetItemByIdAsync(Guid id)
        {
            return await Items.FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<int> UpdateAsync(Post item)
        {
            var rec = await Items.FirstOrDefaultAsync(x => x.ID == item.ID);
            if (rec != default) Context.Update(item);
            else await Context.AddAsync(item);
            return await Context.SaveChangesAsync();
        }
    }
}
