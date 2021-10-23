using System;

namespace Expotec2021.Domain.Entities
{
    public sealed  class ListTask : Base
    {
        public string  Description { get;  set; }
        public bool Check { get;  set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}