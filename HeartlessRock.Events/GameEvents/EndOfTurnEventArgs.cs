using HeartlessRock.Events.Abstractions;

namespace HeartlessRock.Events.GameEvents;

public class EndOfTurnEventArgs : GameEventArgs
{
    public EndOfTurnEventArgs(IEventInitiator initiator, byte repeats)
        : base(initiator, repeats)
    {
        EventTags.Add(EventTag.EndOfTurn);
    }
}
