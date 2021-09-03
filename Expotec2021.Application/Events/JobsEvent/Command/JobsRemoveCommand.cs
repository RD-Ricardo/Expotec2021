namespace Expotec2021.Application.Events.JobsEvent.Command
{
    public class JobsRemoveCommand : JobsCommand
    {
        public int Id { get; private  set; }
        public JobsRemoveCommand(int id)
        {
            Id = id;
        }
    }
}