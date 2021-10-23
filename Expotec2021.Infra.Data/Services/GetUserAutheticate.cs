using System.Linq;
using System.Threading.Tasks;
using Expotec2021.Domain.Auth;
using Expotec2021.Domain.Entities;
using Expotec2021.Infra.Data.context;
using Microsoft.EntityFrameworkCore;

namespace Expotec2021.Infra.Data.Services
{
    public class GetUserAutheticate : IGetUserAuthenticate
    {
        
        private readonly Context _context; 

        public GetUserAutheticate(Context context)
        {
            _context = context;
        }
        public async Task<ApplicationUser> GetUserAuthenticate(string user)
        {
            return await _context.Users.Where(c => c.Id == user).FirstOrDefaultAsync();
        }
    }
}