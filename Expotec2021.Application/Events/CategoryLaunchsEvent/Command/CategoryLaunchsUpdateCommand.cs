namespace Expotec2021.Application.Events.CategoryLaunchsEvent.Command
{
    public class CategoryLaunchsUpdateCommand : CategoryLaunchsCommand
    {
        public CategoryLaunchsUpdateCommand(int id)
        {
            Id = id;
        }
        public int Id { get; private  set; }
    }
}