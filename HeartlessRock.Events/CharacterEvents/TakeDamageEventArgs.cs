using HeartlessRock.Events.Abstractions;

namespace HeartlessRock.Events.CharacterEvents
{
    public class TakeDamageEventArgs : CharacterEventArgs
    {
        [EventArg] public readonly int Damage;

        public TakeDamageEventArgs(int damage, IEventInitiator initiator, byte repeats) 
            : base(initiator, repeats)
        {
            Damage = damage;
            EventTags.Add(EventTag.TakeDamage);
        }
    }
}
