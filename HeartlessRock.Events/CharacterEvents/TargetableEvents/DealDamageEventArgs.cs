using HeartlessRock.Events.Abstractions;
using HeartlessRock.Models;

namespace HeartlessRock.Events.CharacterEvents.TargetableEvents;

public class DealDamageEventArgs : TargetableEventArgs
{
    [EventArg] public readonly int Damage;

    public DealDamageEventArgs(int damage, Target target, IEventInitiator initiator, byte repeats)
        : base(target, initiator, repeats)
    {
        Damage = damage;
        EventTags.Add(EventTag.DealDamage);
    }
}
