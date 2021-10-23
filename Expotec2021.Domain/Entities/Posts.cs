using System;
using System.Collections.Generic;

namespace Expotec2021.Domain.Entities
{
    public sealed class Posts  : Base
    {
        public Posts()
        {
            CreateDate = DateTime.Now;
            Likes = 0;
        }
        public string  Description { get;  set; }
        public string  Image { get;  set; }
        public int Likes { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}