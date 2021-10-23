using System;
using System.IO;
using System.Threading.Tasks;
using Expotec2021.Application.DTOs;
using Expotec2021.Application.Interfaces;
using Expotec2021.Domain.Entities;
using Expotec2021.Domain.Interfaces;
using Expotec2021.Web.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Expotec2021.Web.Controllers
{   
    [Authorize]
    public class BlogController : Controller
    {
        private readonly IBlogServices _servicesBlog;
        private readonly IPostsRepository _repository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;
        public BlogController(IBlogServices services, IWebHostEnvironment webHostEnvironment, IPostsRepository repository,
            UserManager<ApplicationUser> user)
        {
            _servicesBlog = services;
            _webHostEnvironment = webHostEnvironment;
            _repository = repository;
            _userManager = user;
        }

        [HttpGet]
        public  async Task<IActionResult> Index()
        {


            var userCurrent = await _userManager.GetUserAsync(User);
            var result = new BlogViewModel
            {
                ListPost = await _servicesBlog.GetAllAsync(),
                UserLogin = await _servicesBlog.GetInformation(userCurrent)
            };   
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Postar(BlogViewModel postViewModel)
        {  
            var user = await _userManager.GetUserAsync(User);
            
            string stringFileName = UploadFile(postViewModel.Post);



            var postDTO = new PostDTO
            {
                Name = postViewModel.Post.Name,
                Description= postViewModel.Post.Description,
                Image = stringFileName,
                CreateDate = DateTime.Now,
                ApplicationUserId = user.Id
            };

            await _servicesBlog.AddAsync(postDTO);
            return RedirectToAction(nameof(Index));
        }

        private string UploadFile(PostViewModel vm)
        {
            string file = null;
            if(vm.Profile != null)
            {
                string upLoadDir =  Path.Combine(_webHostEnvironment.WebRootPath,"Imagens");
                file = Guid.NewGuid().ToString()+"-"+ vm.Profile.FileName;
                string filePath = Path.Combine(upLoadDir, file);

                using(var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    vm.Profile.CopyTo(fileStream);
                }
            }
            return file;
            
        }
    }
}