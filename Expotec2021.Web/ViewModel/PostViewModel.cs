using Microsoft.AspNetCore.Http;

namespace Expotec2021.Web.ViewModel
{
    public class PostViewModel
    {
        public string  Name { get; set; }
        public string  Description { get;  set; }
        public IFormFile  Profile { get; set; }
      
    }
}