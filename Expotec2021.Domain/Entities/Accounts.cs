using System;
using System.Collections.Generic;

namespace Expotec2021.Domain.Entities
{
    public  class Accounts : Base
    {
        public ICollection<Launchs> Launchs { get; set; }
        public string UserId { get; set; }
    }
}