using HeartlessRock.Events.Abstractions;

namespace HeartlessRock.Events.CharacterEvents
{
    public class TakeHealEventArgs : CharacterEventArgs
    {
        [EventArg] public readonly int Health;

        public TakeHealEventArgs(int health, IEventInitiator initiator, byte repeats) 
            : base(initiator, repeats)
        {
            Health = health;
            EventTags.Add(EventTag.TakeHeal);
        }
    }
}
