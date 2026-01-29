using HeartlessRock.Events.Abstractions;
using HeartlessRock.Models.Abstractions;

namespace HeartlessRock.Events.CharacterEvents;

public class TakeBuffEventArgs : CharacterEventArgs
{
    [EventArg] public readonly (int attack, int health) Stats;
    [EventArg] public readonly ICharacter.CharacterEffect Effect;

    public TakeBuffEventArgs((int attack, int health) stats, ICharacter.CharacterEffect effect, IEventInitiator initiator, byte repeats)
        : base(initiator, repeats)
    {
        Stats = stats;
        Effect = effect;

        EventTags.Add(EventTag.TakeBuff);
    }
}
