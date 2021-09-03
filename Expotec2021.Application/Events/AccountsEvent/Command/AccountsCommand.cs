using Expotec2021.Domain.Entities;
using MediatR;

namespace Expotec2021.Application.Events.AccountsEvent.Command
{
    public class AccountsCommand : IRequest<Accounts>
    {
        public string  Name { get; set; }
        public string UserId { get; set; }
    }
}