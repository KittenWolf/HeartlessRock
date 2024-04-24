using HeartlessRock.Events.Abstractions;
using HeartlessRock.Models;

namespace HeartlessRock.Events.CharacterEvents.TargetableEvents
{
    public class AttackEventArgs : TargetableEventArgs
    {
        public AttackEventArgs(Target target, IEventInitiator initiator, byte repeats) 
            : base(target, initiator, repeats)
        {
            EventTags.Add(EventTag.Attack);
        }
    }
}
