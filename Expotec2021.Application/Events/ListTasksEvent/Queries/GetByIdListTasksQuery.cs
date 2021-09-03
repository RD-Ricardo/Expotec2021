using Expotec2021.Domain.Entities;
using MediatR;

namespace Expotec2021.Application.Events.ListTasksEvent.Queries
{
    public class GetByIdListTasksQuery : IRequest<ListTask>
    {
        public int Id { get; private set; }
        public GetByIdListTasksQuery(int id)
        {
            Id = id;
        }
    }
}