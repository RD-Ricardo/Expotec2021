using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expotec2021.Domain.Entities;
using Expotec2021.Domain.Interfaces;
using Expotec2021.Infra.Data.context;
using Microsoft.EntityFrameworkCore;

namespace Expotec2021.Infra.Data.Repositories
{
    public class JobsRepository : IJobsRepository
    {
        private readonly Context _dbContextJobs;
        public JobsRepository(Context dbContextJobs)
        {
            _dbContextJobs = dbContextJobs;
        }
        public async Task<Jobs> CreateAsync(Jobs model, ApplicationUser user)
        {

            var result = new Jobs()
            {
                ApplicationUserId = user.Id,
                CreateDate = System.DateTime.Now
            };

            result = model;

            _dbContextJobs.jobs.Add(model);
            if(model == null)
            {
                return null;
            }
            await _dbContextJobs.SaveChangesAsync();
            return model;
        }

        public async Task <IEnumerable<Jobs>> GetAllJobsAsync()
        {
            IEnumerable<Jobs> query = await _dbContextJobs.jobs
                .OrderBy(e => e.Id)
                .ToListAsync();
                return query;
        }

        public Task<Jobs> GetByIdJobsAsync(int id)
        {
            var result = _dbContextJobs.jobs
               .Where(c => c.Id == id)
               .FirstOrDefaultAsync();

            return result; 
        }

        public async Task<Jobs> UpdateAsync(Jobs model, ApplicationUser user)
        {

            var result = new Jobs()
            {
                ApplicationUserId = user.Id,
                CreateDate = System.DateTime.Now
            };

            model = result;
           _dbContextJobs.jobs.Update(model);

            if(model == null)
            {
                return null;
            }
            await _dbContextJobs.SaveChangesAsync();
            
            return model;
        }

        public async Task<ApplicationUser> GetInformation(ApplicationUser user)
        {
            return await _dbContextJobs.Users.Where(c => c.Id == user.Id).FirstOrDefaultAsync();
        }

    }
}