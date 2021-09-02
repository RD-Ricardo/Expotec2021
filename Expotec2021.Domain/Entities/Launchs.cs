using System;
using System.Collections.Generic;

namespace Expotec2021.Domain.Entities
{
    public sealed class Launchs : Base
    {
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string  Description { get; private set; }
        public decimal  price { get; private set; }
        public Operation  Operation { get; private set; }
        public int CategoryId { get; set; }
        public CategoryLaunch Category { get; set; }
        public int AccountsId { get; set; }
        public Accounts Accounts { get; set; }
    }
}