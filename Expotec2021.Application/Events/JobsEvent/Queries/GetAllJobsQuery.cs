using System.Collections.Generic;
using Expotec2021.Domain.Entities;
using MediatR;

namespace Expotec2021.Application.Events.JobsEvent.Queries
{
    public class GetAllJobsQuery : IRequest<IEnumerable<Jobs>>
    {
        
    }
}