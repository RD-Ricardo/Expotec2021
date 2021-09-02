namespace Expotec2021.Domain.Entities
{
    public abstract class Base
    {
        public int Id { get; set; }
        public string  Name { get; private set; }
    }
}