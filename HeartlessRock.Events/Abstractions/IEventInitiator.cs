namespace HeartlessRock.Events.Abstractions
{
    public interface IEventInitiator
    {
        ICollection<Enum> InitiatorTags { get; }

        void PushEvent(GameEventArgs args);
        void InitEvents();
        string ToString();
    }
}
