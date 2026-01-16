using HeartlessRock.Events.Abstractions;

namespace HeartlessRock.Events.CharacterEvents;

public abstract class CharacterEventArgs : GameEventArgs
{
    public CharacterEventArgs(IEventInitiator initiator, byte repeats) 
        : base(initiator, repeats)
    {
        EventTags.Add(EventTag.CharacterEvent);
    }
}
