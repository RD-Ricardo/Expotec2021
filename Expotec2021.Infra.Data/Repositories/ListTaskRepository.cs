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

        public async  Task<IEnumerable<ListTask>> GetAllListTaskAsync()
        {
            IEnumerable<ListTask> query = await _dbcontextListTask.listTasks
                .OrderBy(o => o.CreateDate)
                .ToListAsync();
                return query;
        }

        public async Task<ListTask> GetByIdListTaskAsync(int id)
        {
           var result = await _dbcontextListTask.listTasks
            .Where(c => c.Id == id)
            .FirstOrDefaultAsync();
            if(result == null)
            {
                return null;
            }
            return result;
        }

        public async Task<ListTask> UpdateAsync(ListTask model)
        {
           _dbcontextListTask.listTasks.Update(model);  
           if(model == null) return null;
            await _dbcontextListTask.SaveChangesAsync();
            return model;
        }
    }
}