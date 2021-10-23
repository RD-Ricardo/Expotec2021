using System;
using System.Collections.Generic;

namespace Expotec2021.Domain.Entities
{
    public sealed class CategoryLaunch  
    {
        public CategoryLaunch(int id, string name)
        {
            Id = id;
            Name = name;
        }
       public int Id { get;  private set; }
       public string  Name { get; private set; }
       public ICollection<Launchs> Launchs { get; set; }
    }
}