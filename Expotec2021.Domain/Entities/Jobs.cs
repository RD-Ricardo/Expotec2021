using System;

namespace Expotec2021.Domain.Entities
{
    public sealed class Jobs : Base
    { 
        public string  Description { get; private set; }
        public string Location { get; private set; }
        public string Contact { get; private set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }     
        public string UserId { get; set; }
    }
}