using System;

namespace Expotec2021.Domain.Entities
{
    public abstract class Base
    {

        public Base()
        {
            CreateDate = System.DateTime.Now;
        }
        public int Id { get;   set; }
        public string  Name { get;   set;}
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }  
    }
}