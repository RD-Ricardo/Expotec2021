using System;
using Expotec2021.Domain.Entities;
using MediatR;

namespace Expotec2021.Application.Events.JobsEvent.Command
{
    public class JobsCommand : IRequest<Jobs>
    {
        public string  Description { get;  set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }     
        public string UserId { get; set; }
    }
}