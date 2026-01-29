using HeartlessRock.Events.Abstractions;
using HeartlessRock.Models;
using HeartlessRock.Models.Abstractions;

namespace HeartlessRock.Events.CharacterEvents.TargetableEvents;

public class DealBuffEventArgs : TargetableEventArgs
{
    [EventArg] public readonly (int attack, int health) Stats;
    [EventArg] public readonly ICharacter.CharacterEffect Effect;

    public DealBuffEventArgs((int attack, int health) stats, ICharacter.CharacterEffect effect, Target target, IEventInitiator initiator, byte repeats)
        : base(target, initiator, repeats)
    {
        Stats = stats;
        Effect = effect;
        EventTags.Add(EventTag.DealBuff);
    }
}
