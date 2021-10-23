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
    public class TarefasServices : ITarefasServices
    {
        private readonly IMapper _mapper;
        private readonly IListTaskRepository _repository;

        public TarefasServices(IMapper mapper, IListTaskRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
      
        public async  Task AddAsync(ListTasksDTO model)
        {
            var task = _mapper.Map<ListTask>(model);
            await _repository.CreateAsync(task);
        }

        public async Task<ApplicationUser> GetInformation(ApplicationUser user)
        {
            return await  _repository.GetInformation(user); 
        }

        public async Task<IEnumerable<ListTasksDTO>> GettALl(ApplicationUser user)
        {
            var result = await _repository.GetAllListTaskAsync(user);
            return _mapper.Map<IEnumerable<ListTasksDTO>>(result);
        }

        public async Task RemoveAsync(int id)
        {

            var pegaPeloId = await  _repository.GetByIdListTaskAsync(id); 
            var task = _mapper.Map<ListTask>(pegaPeloId);
            await _repository.DeleteAsync(task);
        }

        public async Task UpdateAsync(int id)
        {   
            var getId = await _repository.GetByIdListTaskAsync(id);
            var task = _mapper.Map<ListTask>(getId);
            await _repository.UpdateAsync(task);
            
           
        }
    }
}