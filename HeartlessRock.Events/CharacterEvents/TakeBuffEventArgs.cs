using HeartlessRock.Events.Abstractions;
using HeartlessRock.Models.Abstractions;

namespace HeartlessRock.Events.CharacterEvents;

public class TakeBuffEventArgs : CharacterEventArgs
{
    [EventArg] public readonly (int attack, int health) Stats;
    [EventArg] public readonly ICharacter.CharacterProp Prop;

    public TakeBuffEventArgs((int attack, int health) stats, ICharacter.CharacterProp prop, IEventInitiator initiator, byte repeats) 
        : base(initiator, repeats)
    {
        Stats = stats;
        Prop = prop;

        EventTags.Add(EventTag.TakeBuff);
    }
}
