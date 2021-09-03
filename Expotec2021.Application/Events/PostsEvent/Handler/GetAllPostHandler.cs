using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Expotec2021.Application.Events.PostsEvent.Queries;
using Expotec2021.Domain.Entities;
using Expotec2021.Domain.Interfaces;
using MediatR;

namespace Expotec2021.Application.Events.PostsEvent.Handler
{
    public class GetAllPostHandler : IRequestHandler<GetAllPostsQuery, IEnumerable<Posts>>
    {
        private readonly IPostsRepository _repositotyPosts;
        public GetAllPostHandler(IPostsRepository repositoryPosts)
        {
            _repositotyPosts = repositoryPosts;
        }
        public async Task<IEnumerable<Posts>> Handle(GetAllPostsQuery request, CancellationToken cancellationToken)
        {
            return await _repositotyPosts.GetAllPostsAsync();
        }
    }
}