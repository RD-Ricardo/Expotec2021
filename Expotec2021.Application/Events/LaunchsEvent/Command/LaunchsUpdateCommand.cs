namespace Expotec2021.Application.Events.LaunchsEvent.Command
{
    public class LaunchsUpdateCommand : LaunchsCommand
    {
        public int Id { get; set; }
        public LaunchsUpdateCommand(int id)
        {
            Id = id;
        }
    }
}