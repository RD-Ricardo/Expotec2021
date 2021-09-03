using Expotec2021.Domain.Entities;
using MediatR;

namespace Expotec2021.Application.Events.LaunchsEvent.Queries
{
    public class GetByIdLaunchsQuery : IRequest<Launchs>
    {
        public int  Id { get; private set; }
        public GetByIdLaunchsQuery(int id)
        {
            Id = id;
        }
    }
}