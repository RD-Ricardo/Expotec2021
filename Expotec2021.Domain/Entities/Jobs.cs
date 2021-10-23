namespace Expotec2021.Domain.Entities
{
    public sealed class Jobs : Base
    { 
        public string  Description { get;  set; }
        public string Location { get;  set; }
        public string Contact { get;  set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser  { get; set; }
    }
}