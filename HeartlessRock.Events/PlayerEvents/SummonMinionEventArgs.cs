using HeartlessRock.Events.Abstractions;
using HeartlessRock.Models.Objects;

namespace HeartlessRock.Events.PlayerEvents;

public class SummonMinionEventArgs : PlayCardEventArgs
{
    public SummonMinionEventArgs(Minion minion, IEventInitiator initiator, byte repeats)
        : base(minion, initiator, repeats)
    {
        EventTags.Add(EventTag.SummonMinion);
    }
}
