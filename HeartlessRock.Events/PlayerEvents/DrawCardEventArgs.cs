using HeartlessRock.Events.Abstractions;

namespace HeartlessRock.Events.PlayerEvents;

public class DrawCardEventArgs : PlayerEventArgs
{
    [EventArg] public readonly byte Cards;

    public DrawCardEventArgs(byte count, IEventInitiator initiator, byte repeats) 
        : base(initiator, repeats)
    {
        Cards = count;
        EventTags.Add(EventTag.DrawCard);
    }
}
