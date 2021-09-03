

namespace Expotec2021.Application.Events.ListTasksEvent.Command
{
    public class ListTasksRemoveCommand : ListTasksCommand
    {
        public int Id { get; private set; }
        public ListTasksRemoveCommand(int id)
        {   
            Id = id;
        }
    }
}