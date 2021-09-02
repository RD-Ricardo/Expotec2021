using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expotec2021.Domain.Entities;
using Expotec2021.Domain.Interfaces;
using Expotec2021.Infra.Data.context;
using Microsoft.EntityFrameworkCore;

namespace Expotec2021.Infra.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _dbContextCategory; 
        public CategoryRepository(Context dbContextCategory)
        {
            _dbContextCategory = dbContextCategory;
        }

        public async Task<CategoryLaunch> CreateAsync(CategoryLaunch model)
        {
            _dbContextCategory.categoryLaunches.Add(model);
            if(model == null)
            {
                return null;
            }
            await _dbContextCategory.SaveChangesAsync();
            return model;
        }
        public async Task<CategoryLaunch> DeleteAsync(CategoryLaunch model)
        {
             _dbContextCategory.categoryLaunches.Remove(model);
            if(model == null)
            {
                return null;
            }
            await _dbContextCategory.SaveChangesAsync();
            return model;
        }

        public async Task<IEnumerable<CategoryLaunch>> GetAllCategoriesAsync()
        {
            IEnumerable<CategoryLaunch> query = await _dbContextCategory.categoryLaunches
                .ToListAsync();
            return query;
        }

        public async Task<CategoryLaunch> GetByIdCategoriesAsync(int id)
        {
           var result = await _dbContextCategory.categoryLaunches
            .Where(c => c.Id == id)
            .FirstOrDefaultAsync();
            if(result == null)
            {
                return null;
            }
            return result;
        }

        public async Task<CategoryLaunch> UpdateAsync(CategoryLaunch model)
        {
            _dbContextCategory.categoryLaunches.Update(model);
            if(model == null)
            {
                return null;
            }
            await _dbContextCategory.SaveChangesAsync();
            return model;
        }
    }
}