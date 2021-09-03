using System;
using Expotec2021.Domain.Entities;
using MediatR;

namespace Expotec2021.Application.Events.LaunchsEvent.Command
{
    public class LaunchsCommand : IRequest<Launchs>
    {
        public DateTime CreateDate { get; private set; }
        public DateTime UpdateDate { get; private set; }
        public string  Description { get; private set; }
        public decimal  price { get; private set; }
        public Operation  Operation { get; private set; }
        public int CategoryId { get; set; }
        public CategoryLaunch Category { get; set; }
        public int AccountsId { get; set; }
    }
}