namespace Expotec2021.Application.Events.PostsEvent.Command
{
    public class PostsRemoveCommand : PostsCommand
    {
        public int Id { get; private set; }

        public PostsRemoveCommand(int id)
        {
            Id = id;
        }
    }
}