using System;
using System.Collections.Generic;

namespace Expotec2021.Domain.Entities
{
    public  class Launchs 
    {
        public Launchs()
        {
            
            CreateDate = System.DateTime.Now;
        }
        public int Id { get; set; }
        public string  Name { get; set; }
        public decimal  price { get;  set; }
        public DateTime CreateDate { get; set; }
        public Operation  Operation { get;  set; }
        public int CategoryId { get; set; }
        public CategoryLaunch Category { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}