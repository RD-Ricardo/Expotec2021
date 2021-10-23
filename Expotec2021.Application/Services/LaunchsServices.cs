using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Expotec2021.Application.DTOs;
using Expotec2021.Application.Interfaces;
using Expotec2021.Domain.Entities;
using Expotec2021.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Expotec2021.Application.Services
{
    public class LaunchsServices : ILaunchsServices
    {
        private readonly IMapper _mapper;
        private readonly ILaunchsRepository _repository;
        public LaunchsServices(IMapper mapper, ILaunchsRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task AddAsync(LaunchsDTO model)
        {
            var launch = _mapper.Map<Launchs>(model);
            await _repository.CreateAsync(launch);
        }

        public async Task<ApplicationUser> GetInformation(ApplicationUser user)
        {
             return await  _repository.GetInformation(user); 
        }

        public async Task<IEnumerable<LaunchsDTO>> GettALl(ApplicationUser user)
        {
            var launchs = await _repository.GetAllLaunhsAsync(user);
            return _mapper.Map<IEnumerable<LaunchsDTO>>(launchs);
        }

        public async Task RemoveAsync(LaunchsDTO model, ApplicationUser user)
        {
            var launch = _mapper.Map<Launchs>(model);
            await _repository.DeleteAsync(launch, user);
        }

        public async Task UpdateAsync(LaunchsDTO model, ApplicationUser user)
        {
            var launch = _mapper.Map<Launchs>(model);
            await _repository.UpdateAsync(launch, user);
        }
      
    }
}