using System.Collections.Generic;
using Expotec2021.Domain.Entities;
using MediatR;

namespace Expotec2021.Application.Events.AccountsEvent.Queries
{
    public class GetByIdAccountsQuery : IRequest<Accounts>
    {
        public GetByIdAccountsQuery(string id)
        {
            Id = id;
        }
        public string  Id { get; private set; }
    }
}