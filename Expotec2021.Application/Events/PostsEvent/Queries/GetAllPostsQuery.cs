using System.Collections.Generic;
using Expotec2021.Domain.Entities;
using MediatR;

namespace Expotec2021.Application.Events.PostsEvent.Queries
{
    public class GetAllPostsQuery : IRequest<IEnumerable<Posts>>
    {
        
    }
}