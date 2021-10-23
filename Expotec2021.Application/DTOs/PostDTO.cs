using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Expotec2021.Application.DTOs
{
    public class PostDTO
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string  Description { get;  set; }
        public DateTime CreateDate { get; set; }
        public string  Image { get;  set; }
        public int Likes { get; set; }
        public string ApplicationUserId { get; set; }
    }
}