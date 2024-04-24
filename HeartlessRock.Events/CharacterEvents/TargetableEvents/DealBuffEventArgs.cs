using HeartlessRock.Events.Abstractions;
using HeartlessRock.Models;
using HeartlessRock.Models.Abstractions;

namespace HeartlessRock.Events.CharacterEvents.TargetableEvents
{
    public class DealBuffEventArgs : TargetableEventArgs
    {
        [EventArg] public readonly (int attack, int health) Stats;
        [EventArg] public readonly ICharacter.CharacterProp Prop;

        public DealBuffEventArgs((int attack, int health) stats, ICharacter.CharacterProp prop, Target target, IEventInitiator initiator, byte repeats) 
            : base(target, initiator, repeats)
        {
            Stats = stats;
            Prop = prop;
            EventTags.Add(EventTag.DealBuff);
        }
    }
}
