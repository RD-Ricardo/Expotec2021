namespace Expotec2021.Application.Events.AccountsEvent.Command
{
    public class AccountsRemoveCommand : AccountsCommand
    {
        public AccountsRemoveCommand(int id)
        {
            Id = id;
        }
        public int Id { get; private set; }
    }
}