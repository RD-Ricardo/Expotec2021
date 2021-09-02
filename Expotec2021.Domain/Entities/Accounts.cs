using System;
using System.Collections.Generic;

namespace Expotec2021.Domain.Entities
{
    public  class Accounts 
    {
        public int Id { get; set; }
        public string  Name { get; private set; }
        public ICollection<Launchs> Launchs { get; set; }
        public string UserId { get; set; }
    }
}