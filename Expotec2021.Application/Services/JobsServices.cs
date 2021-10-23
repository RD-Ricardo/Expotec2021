using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Expotec2021.Application.DTOs;
using Expotec2021.Application.Interfaces;
using Expotec2021.Domain.Entities;
using Expotec2021.Domain.Interfaces;

namespace Expotec2021.Application.Services
{
    public class JobsServices : IJobsServices
    {
        private readonly IMapper _mapper;
        private readonly IJobsRepository _repository;
        public JobsServices(IMapper mapper, IJobsRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task AddAsync(JobsDTO model, ApplicationUser user)
        {
            var jobs = _mapper.Map<Jobs>(model);
            await  _repository.CreateAsync(jobs, user);
        }

        public async Task<IEnumerable<JobsDTO>> GetAll()
        {
            var jobs = await _repository.GetAllJobsAsync();
            return _mapper.Map<IEnumerable<JobsDTO>>(jobs);
        }

        public async Task<ApplicationUser> GetInformation(ApplicationUser user)
        {
             return await  _repository.GetInformation(user); 
        }

        public async Task UpdateAsync(JobsDTO model, ApplicationUser user)
        {
            var jobs = _mapper.Map<Jobs>(model);
            await  _repository.UpdateAsync(jobs, user);
        }
    }
}