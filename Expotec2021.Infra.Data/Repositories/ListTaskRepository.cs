using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expotec2021.Domain.Entities;
using Expotec2021.Domain.Interfaces;
using Expotec2021.Infra.Data.context;
using Microsoft.EntityFrameworkCore;

namespace Expotec2021.Infra.Data.Repositories
{
    public class ListTaskRepository : IListTaskRepository
    {
        private readonly Context _dbcontextListTask;
        public ListTaskRepository(Context context)
        {
            _dbcontextListTask = context;
            _dbcontextListTask.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        public async Task<ListTask> CreateAsync(ListTask model)
        {   
            _dbcontextListTask.listTasks.Add(model);

            await _dbcontextListTask.SaveChangesAsync();

            return model;
        }

        public async Task<ListTask> DeleteAsync(ListTask model)
        {

            _dbcontextListTask.listTasks.Remove(model);
            await _dbcontextListTask.SaveChangesAsync();
            return model;
        }

        public async  Task<IEnumerable<ListTask>> GetAllListTaskAsync(ApplicationUser user)
        {
            IEnumerable<ListTask> query = await _dbcontextListTask.listTasks
                .OrderByDescending(c => c.CreateDate)
                .Where(c => c.ApplicationUserId == user.Id)
                .ToListAsync();
                return query;
        }
        

        public async Task<ApplicationUser> GetInformation(ApplicationUser user)
        {
            return await _dbcontextListTask.Users.Where(c => c.Id == user.Id).FirstOrDefaultAsync();
        }

        public async Task<ListTask> GetByIdListTaskAsync(int id)
        {
           return await _dbcontextListTask.listTasks.FindAsync(id);
        }

        public async Task<ListTask> UpdateAsync(ListTask model)
        {

            var novoModel = new ListTask()
            {
                Id = 101,
                Name = "Eu coloquei esse nome",
                Description = "Tentando fazer um update ",
                Check =  true
            };
            

            model = novoModel;
            _dbcontextListTask.listTasks.Update(model);
            await _dbcontextListTask.SaveChangesAsync();
            return model;
        }
    }
}