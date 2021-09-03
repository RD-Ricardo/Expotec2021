using System;
using Expotec2021.Domain.Entities;
using MediatR;

namespace Expotec2021.Application.Events.ListTasksEvent.Command
{
    public class ListTasksCommand : IRequest<ListTask>
    {
        public DateTime CreateDate { get; set; }
        public string  Description { get; private set; }
        public bool Check { get; private set; }
        public string UserId { get; set; }
    }
}