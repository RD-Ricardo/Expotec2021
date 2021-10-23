using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Expotec2021.Application.DTOs;
using Expotec2021.Application.Interfaces;
using Expotec2021.Domain.Entities;
using Expotec2021.Domain.Interfaces;

namespace Expotec2021.Application.Services
{
    public class CategoriesServices : ICategoriesServices
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _repository;
        public CategoriesServices(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _repository = categoryRepository;
        }
        public async Task AddAsync(CategoryLaunchDTO model)
        {
            var categoryDto = _mapper.Map<CategoryLaunch>(model);
            await _repository.CreateAsync(categoryDto);
        }

        public async Task<IEnumerable<CategoryLaunchDTO>> GettALl()
        {
            var category = await  _repository.GetAllCategoriesAsync();
            return _mapper.Map<IEnumerable<CategoryLaunchDTO>>(category);
        }

        public async Task RemoveAsync(CategoryLaunchDTO model)
        {
            var categoryDto = _mapper.Map<CategoryLaunch>(model);
            await _repository.DeleteAsync(categoryDto);
        }

        public async Task UpdateAsync(CategoryLaunchDTO model)
        {
            var categoryDto = _mapper.Map<CategoryLaunch>(model);
            await _repository.UpdateAsync(categoryDto);
        }
    }
}