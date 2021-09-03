namespace Expotec2021.Application.Events.AccountsEvent.Command
{
    public class AccountsUpdateCommand
    {
        public AccountsUpdateCommand(int id)
        {
            Id = id;
        }
        public int  Id { get; private set; }
    }
}