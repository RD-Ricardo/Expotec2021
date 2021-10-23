using System.Collections.Generic;
using Expotec2021.Application.DTOs;
using Expotec2021.Domain.Entities;

namespace Expotec2021.Web.ViewModel
{
    public class BlogViewModel
    {
        public IEnumerable<PostDTO> ListPost { get; set; }
        public PostViewModel Post { get; set; }
       
       public ApplicationUser UserLogin { get; set; }
    }
}