using System;
using Expotec2021.Domain.Entities;
using MediatR;

namespace Expotec2021.Application.Events.PostsEvent.Command
{
    public class PostsCommand : IRequest<Posts>
    {
        public string  Description { get;  set; }
        public string  Image { get;  set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int Likes { get; set; }
        public string UserId  { get; set; }
    }
}