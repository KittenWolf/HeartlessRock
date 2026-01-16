using HeartlessRock.Events.Abstractions;
using HeartlessRock.Models;

namespace HeartlessRock.Events.CharacterEvents.TargetableEvents;

public abstract class TargetableEventArgs : GameEventArgs
{
    public readonly Target Target;

    public TargetableEventArgs(Target target, IEventInitiator initiator, byte repeats)
        : base(initiator, repeats)
    {
        Target = target;
        EventTags.Add(EventTag.TargetableEvent);
    }
}
