using System.ComponentModel.DataAnnotations;
using Expotec2021.Domain.Entities;

namespace Expotec2021.Application.DTOs
{
    public class CategoryLaunchDTO
    {
        public int Id { get; set; }
        // [Required(ErrorMessage ="The name is required")]
        // [MinLength(3)]
        // [MaxLength(100)]
        public string  Name { get;   set;}
    }
}