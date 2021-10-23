using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace Expotec2021.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string  ImgAvatar { get; set; }
        public string  CodIbge { get; set; }
        ICollection<Launchs> Launchs {get; set;}
        ICollection<Posts> Posts {get; set;}
        ICollection<Jobs> Jobs {get; set;}
        ICollection<ListTask> ListTasks {get; set;}
        ICollection<Claim> Claims {get; set;}
    }
}