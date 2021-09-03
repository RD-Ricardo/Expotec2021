using System.Collections.Generic;
using Expotec2021.Domain.Entities;
using MediatR;

namespace Expotec2021.Application.Events.LaunchsEvent.Queries
{
    public class GetAllLaunchsQuery : IRequest<IEnumerable<Launchs>>
    {
        
    }
}