using System;

namespace Expotec2021.Domain.Entities
{
    public sealed  class ListTask : Base
    {
        public DateTime CreateDate { get; set; }
        public string  Description { get; private set; }
        public bool Check { get; private set; }
        public string UserId { get; set; }
    }
}