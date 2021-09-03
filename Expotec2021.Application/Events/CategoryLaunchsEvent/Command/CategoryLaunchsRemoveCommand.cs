namespace Expotec2021.Application.Events.CategoryLaunchsEvent.Command
{
    public class CategoryLaunchsRemoveCommand : CategoryLaunchsCommand
    {
        public int Id { get; private set; }
        public CategoryLaunchsRemoveCommand(int id)
        {
            Id = id;
        }
        
    }
}