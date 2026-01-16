namespace HeartlessRock.Events.Abstractions;

public interface IEventListener
{
    void Response(GameEventArgs.EventTag eventTag, ICollection<Enum> initiatorTags);
}
