using HeartlessRock.Events.Abstractions;
using HeartlessRock.Models;

namespace HeartlessRock.Events.CharacterEvents.TargetableEvents
{
    public class DealHealEventArgs : TargetableEventArgs
    {
        [EventArg] public readonly int Health;

        public DealHealEventArgs(int health, Target target, IEventInitiator initiator, byte repeats) 
            : base(target, initiator, repeats)
        {
            Health = health;
            EventTags.Add(EventTag.DealHeal);
        }
    }
}
