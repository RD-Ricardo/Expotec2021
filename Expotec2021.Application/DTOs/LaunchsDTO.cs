using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Expotec2021.Domain.Entities;

namespace Expotec2021.Application.DTOs
{
    public class LaunchsDTO
    {
        public int Id { get; set; }
        public string  Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime CreateDate { get; set; }

        [Required(ErrorMessage ="The price is required")]
        [Column(TypeName = "decimal(6,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DisplayName("Price")]
        //[MinLength(4)]
        //[MaxLength(100)]
        public decimal  price { get;  set; }
        public Operation  Operation { get;  set; }
        public int CategoryId { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}