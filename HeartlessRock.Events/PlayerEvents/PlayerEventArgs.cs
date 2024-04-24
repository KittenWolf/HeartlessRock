using HeartlessRock.Events.Abstractions;

namespace HeartlessRock.Events.PlayerEvents
{
    public abstract class PlayerEventArgs : GameEventArgs
    {
        public PlayerEventArgs(IEventInitiator initiator, byte repeats) 
            : base(initiator, repeats)
        {
            EventTags.Add(EventTag.PlayerEvent);
        }
    }
}
