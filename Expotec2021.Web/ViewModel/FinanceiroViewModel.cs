using System.Collections.Generic;
using Expotec2021.Application.DTOs;
using Expotec2021.Domain.Entities;

namespace Expotec2021.Web.ViewModel
{
    public class FinanceiroViewModel
    {
        public LaunchsDTO LaunchsDTO { get; set; }
        public IEnumerable<LaunchsDTO> ListLaunhsDTO { get; set; }
        public CategoryLaunchDTO CategoryLaunchDTO {get;set;}
        public IEnumerable<CategoryLaunchDTO> ListCategoriesDTO {get;set;}
        public ApplicationUser user { get; set; }

    }
}