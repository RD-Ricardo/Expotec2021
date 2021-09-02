using System;
using System.Collections.Generic;

namespace Expotec2021.Domain.Entities
{
    public sealed class Posts  : Base
    {
        public string  Description { get; private set; }
        public string  Image { get; private set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int Likes { get; set; }
        public string UserId  { get; set; }
    }
}