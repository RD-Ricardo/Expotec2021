using System.Collections.Generic;
using System.Threading.Tasks;
using Expotec2021.Domain.Entities;
using Expotec2021.Domain.Interfaces;
using Expotec2021.Infra.Data.context;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Expotec2021.Infra.Data.Repositories
{
    public class PostsRepository : IPostsRepository
    {
        private readonly Context _dbContext;

        public PostsRepository(Context dbContext)
        {
            _dbContext = dbContext;
             _dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        public async Task<Posts> CreateAsync(Posts model)
        {
            _dbContext.posts.Add(model);
            await _dbContext.SaveChangesAsync();
            return model;
        }

        public async Task<Posts> DeleteAsync(Posts model)
        {
            _dbContext.posts.Remove(model);
            await _dbContext.SaveChangesAsync();
            return model;
        }

        public async Task<IEnumerable<Posts>> GetAllPostsAsync()
        {
            IEnumerable<Posts> query = await _dbContext.posts.OrderByDescending(c => c.CreateDate).ToListAsync();;
            return query;
        }

        public async Task<Posts> GetByIdPostsAsync(int id)
        {
           var query = await _dbContext.posts.FirstOrDefaultAsync(c => c.Id  == id);
           return query;
        }

        public async Task<ApplicationUser> GetInformation(ApplicationUser user)
        {
            return await _dbContext.Users.Where(c => c.Id == user.Id).FirstOrDefaultAsync();
        }


        public async Task<Posts> UpdateAsync(Posts model)
        {
           _dbContext.posts.Update(model);
           await _dbContext.SaveChangesAsync();
           return model;
        }
    }
}


