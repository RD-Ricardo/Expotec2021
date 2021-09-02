using System.Collections.Generic;
using Expotec2021.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Expotec2021.Infra.Identity.models
{
    public class User : IdentityUser
    {
        public ICollection<Posts> Posts { get; set; }
        public ICollection<ListTask> ListTasks { get; set; }
        public ICollection<Accounts> Accounts { get; set; }
        public ICollection<Jobs> Jobs { get; set; }
        public string  City { get; private set; }
        public string  State { get; private set; }
        public string  Cep { get; private set; }
        
    }
}