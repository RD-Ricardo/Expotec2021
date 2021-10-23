using System;
using System.ComponentModel.DataAnnotations;

namespace Expotec2021.Application.DTOs
{
    public class ListTasksDTO
    {
        public ListTasksDTO()
        {
            CreateDate = System.DateTime.Now;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime CreateDate { get; set; }
        public string  Description { get; set; }
        public bool Check { get;  set; }
        public string ApplicationUserId { get; set; }
    }
}