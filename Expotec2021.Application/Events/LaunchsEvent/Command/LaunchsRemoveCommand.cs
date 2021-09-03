namespace Expotec2021.Application.Events.LaunchsEvent.Command
{
    public class LaunchsRemoveCommand : LaunchsCommand
    {
        public LaunchsRemoveCommand(int id)
        {
            Id = id;
        }
        public int Id { get; private set; }
    }
}