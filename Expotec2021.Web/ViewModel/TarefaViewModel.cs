using System.Collections.Generic;
using Expotec2021.Application.DTOs;
using Expotec2021.Domain.Entities;

namespace Expotec2021.Web.ViewModel
{
    public class TarefaViewModel
    {

        public TarefaViewModel()
        {
            
        }
        public ListTasksDTO TasksCreate { get; set; }
        public IEnumerable<ListTasksDTO> ListTask { get; set; }
        public ApplicationUser user { get; set; }
        
    }
}