namespace Cqrs.Hotel.Command.Infraestructure
{
    public class Message : IMessage
    {
        public string Name { get; protected set; }
    }
}
