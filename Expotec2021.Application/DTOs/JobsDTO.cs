using System.ComponentModel.DataAnnotations;

namespace Expotec2021.Application.DTOs
{
    public class JobsDTO
    {
        [MinLength(10)]
        [MaxLength(100)]
        public string  Description { get;  set; }

        [Required(ErrorMessage ="The name is required")]
        [MinLength(5)]
        [MaxLength(100)]
        public string Location { get;  set; }
        
        [Required(ErrorMessage ="The name is required")]
        [MinLength(11)]
        [MaxLength(11)]
        public string Contact { get;  set; }
        public string ApplicationUserId { get; set; }
    }
}