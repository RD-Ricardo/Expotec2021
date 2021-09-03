using System.Collections.Generic;
using Expotec2021.Domain.Entities;
using MediatR;

namespace Expotec2021.Application.Events.ListTasksEvent.Queries
{
    public class GetAllListTasksQuery : IRequest<IEnumerable<ListTask>>
    {
        
    }
}