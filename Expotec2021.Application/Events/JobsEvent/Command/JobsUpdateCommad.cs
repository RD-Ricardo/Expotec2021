namespace Expotec2021.Application.Events.JobsEvent.Command
{
    public class JobsUpdateCommad : JobsCommand
    {
        public int Id { get; private set; }
        public JobsUpdateCommad(int id)
        {
            Id = id;
        }
    }
}