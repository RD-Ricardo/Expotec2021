using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expotec2021.Domain.Entities;
using Expotec2021.Domain.Interfaces;
using Expotec2021.Infra.Data.context;
using Microsoft.EntityFrameworkCore;

namespace Expotec2021.Infra.Data.Repositories
{
    public class LaunchsRepository : ILaunchsRepository
    {
        private readonly Context _dbContextLaunhs; 
        public LaunchsRepository(Context context)
        {
            _dbContextLaunhs = context;
        }
        public async Task<bool> CreateAsync(Launchs model)
        {
           var lancamento =  new Launchs()
           {
               ApplicationUserId = model.ApplicationUserId,
               Name = model.Name,
               price = model.price,
               Operation = model.Operation,
               CategoryId = model.CategoryId
               
           };

           _dbContextLaunhs.launchs.Add(lancamento);
           var resultado = await _dbContextLaunhs.SaveChangesAsync();
           return resultado == 1;
        }

        public async Task<Launchs> DeleteAsync(Launchs model, ApplicationUser user)
        {
            var result = new Launchs()
            {
                ApplicationUserId = user.Id,
            };

            model =  result;

            _dbContextLaunhs.launchs.Remove(model);

            if(model == null)
            {
                return null;
            }

            await _dbContextLaunhs.SaveChangesAsync();
            return model;
        }

        public async Task<IEnumerable<Launchs>> GetAllLaunhsAsync(ApplicationUser userid)
        {
            IEnumerable<Launchs> query = await  _dbContextLaunhs.launchs
                .OrderByDescending(c => c.CreateDate)
                .Where(c => c.ApplicationUserId == userid.Id)
                .ToListAsync();
            return query;
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

        public async Task<ApplicationUser> GetUserOk(ApplicationUser use)
        {
            var result =  await _dbContextLaunhs.Users.Where(c => c.Id == use.Id).FirstOrDefaultAsync();
            return result;
        }

        public async Task<Launchs> UpdateAsync(Launchs model, ApplicationUser user)
        {
            var result =  new Launchs()
            {
                ApplicationUserId = user.Id,
            };

            model = result;

            _dbContextLaunhs.launchs.Update(model);
            if(model == null)
            {
                return null;
            }
            
            await _dbContextLaunhs.SaveChangesAsync();
            return model;
        }

          
        public async Task<ApplicationUser> GetInformation(ApplicationUser user)
        {
            return await _dbContextLaunhs.Users.Where(c => c.Id == user.Id).FirstOrDefaultAsync();
        }


        // public async Task<Enumerable<Enum>> getAllEnum()
        // {
        //     IEnumerable<Enum> query = await _dbContextLaunhs.launchs.ToListAsync();
        //     return query;
        // }
    }
}