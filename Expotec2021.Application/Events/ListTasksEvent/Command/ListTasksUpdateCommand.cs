namespace Expotec2021.Application.Events.ListTasksEvent.Command
{
    public class ListTasksUpdateCommand : ListTasksCommand
    {
        public int Id { get; private set; }
        public ListTasksUpdateCommand(int id)
        {
            Id = id;
        }
    }
}