using System.Collections.Generic;
using Expotec2021.Domain.Entities;
using MediatR;

namespace Expotec2021.Application.Events.AccountsEvent.Queries
{
    public class GetAllAccountsQuery : IRequest<IEnumerable<Accounts>>
    {
        
    }
}