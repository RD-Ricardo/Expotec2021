using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expotec2021.Domain.Entities;
using Expotec2021.Domain.Interfaces;
using Expotec2021.Infra.Data.context;
using Microsoft.EntityFrameworkCore;

namespace Expotec2021.Infra.Data.Repositories
{
    public class LaunchsRepository : ILaunhsRepository
    {
        private readonly Context _dbContextLaunhs; 
        public LaunchsRepository(Context context)
        {
            _dbContextLaunhs = context;
        }
        public async Task<Launchs> CreateAsync(Launchs model)
        {
            _dbContextLaunhs.launchs.Add(model);
            if(model == null)
            {
                return null;
            }
            await _dbContextLaunhs.SaveChangesAsync();
            return model;
        }

        public async Task<Launchs> DeleteAsync(Launchs model)
        {
            _dbContextLaunhs.launchs.Remove(model);
            if(model == null)
            {
                return null;
            }
            await _dbContextLaunhs.SaveChangesAsync();
            return model;
        }

        public Task<IEnumerable<Launchs>> GetAllLaunhsAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Launchs> GetByIdLaunchsAsync(int id)
        {
            var result = await _dbContextLaunhs.launchs
              .Where(c => c.Id == id)
              .FirstOrDefaultAsync();
              if(result == null)
              {
                  return null;
              }
              return result;
        }

        public async Task<Launchs> UpdateAsync(Launchs model)
        {
            _dbContextLaunhs.launchs.Update(model);
            if(model == null)
            {
                return null;
            }
            await _dbContextLaunhs.SaveChangesAsync();
            return model;
        }
    }
}