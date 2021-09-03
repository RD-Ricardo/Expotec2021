namespace Expotec2021.Application.Events.PostsEvent.Command
{
    public class PostsUpdateCommand : PostsCommand
    {
        public int  Id { get; private set; }
        public PostsUpdateCommand(int id)
        {
            Id = id;
        }
    }
}