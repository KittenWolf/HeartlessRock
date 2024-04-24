using HeartlessRock.Events.Abstractions;
using HeartlessRock.Models;

namespace HeartlessRock.Events.PlayerEvents
{
    public class CastSpellEventArgs : PlayCardEventArgs
    {
        public CastSpellEventArgs(Spell spell, IEventInitiator initiator, byte repeats) 
            : base(spell, initiator, repeats)
        {
            EventTags.Add(EventTag.CastSpell);
        }
    }
}
