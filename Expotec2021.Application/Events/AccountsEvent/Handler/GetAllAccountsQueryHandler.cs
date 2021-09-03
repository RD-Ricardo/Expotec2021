using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Expotec2021.Application.Events.AccountsEvent.Queries;
using Expotec2021.Domain.Entities;
using MediatR;

namespace Expotec2021.Application.Events.AccountsEvent.Handler
{
    public class GetAllAccountsQueryHandler : IRequestHandler<GetAllAccountsQuery, IEnumerable<Accounts>>
    {   

        // private readonly I
        // public GetAllAccountsQueryHandler()
        // {
            
        // }
        public Task<IEnumerable<Accounts>> Handle(GetAllAccountsQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}