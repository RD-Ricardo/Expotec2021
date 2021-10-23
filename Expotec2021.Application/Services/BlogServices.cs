using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Expotec2021.Application.DTOs;
using Expotec2021.Application.Interfaces;
using Expotec2021.Domain.Entities;
using Expotec2021.Domain.Interfaces;
using MediatR;

namespace Expotec2021.Application.Services
{
    public class BlogServices : IBlogServices
    {
        private readonly IMapper _mapper;
        private readonly IPostsRepository _repository;
        public BlogServices(IMapper mapper, IPostsRepository repository)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task AddAsync(PostDTO model)
        {
            var posts =  _mapper.Map<Posts>(model);
            await _repository.CreateAsync(posts);
        }

        public async Task UpdateAsync(PostDTO model)
        {
            var posts =  _mapper.Map<Posts>(model);
            await _repository.UpdateAsync(posts);
        }

        public async Task<IEnumerable<PostDTO>> GetAllAsync()
        {
            var result = await _repository.GetAllPostsAsync();
            return _mapper.Map<IEnumerable<PostDTO>>(result);
        }

        public async Task<ApplicationUser> GetInformation(ApplicationUser user)
        {
             return await  _repository.GetInformation(user); 
        }
    }
}