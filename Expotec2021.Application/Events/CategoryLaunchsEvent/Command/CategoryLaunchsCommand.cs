using Expotec2021.Domain.Entities;
using MediatR;

namespace Expotec2021.Application.Events.CategoryLaunchsEvent.Command
{
    public class CategoryLaunchsCommand : IRequest<CategoryLaunch>
    {
        public string  Name { get;  set;}
    }
    
}