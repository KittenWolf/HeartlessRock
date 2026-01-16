using HeartlessRock.Events.Abstractions;

namespace HeartlessRock.Events.PlayerEvents;

public class GetManaCrystalsEventArgs : PlayerEventArgs
{
    [EventArg] public readonly byte Mana;

    public GetManaCrystalsEventArgs(byte mana, IEventInitiator initiator, byte repeats) 
        : base(initiator, repeats)
    {
        Mana = mana;
        EventTags.Add(EventTag.GetMana);
    }
}
