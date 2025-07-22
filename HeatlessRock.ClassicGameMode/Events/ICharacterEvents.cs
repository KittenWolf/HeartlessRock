using HeartlessRock.Events.CharacterEvents;
using HeartlessRock.Events.CharacterEvents.TargetableEvents;

namespace HeartlessRock.ClassicGameMode.Events
{
    internal interface ICharacterEvents
    {
        EventHandler<AttackEventArgs> AttackEvent { get; set; }
        EventHandler<DealDamageEventArgs> DealDamageEvent { get; set; }
        EventHandler<DealHealEventArgs> DealHealEvent { get; set; }
        EventHandler<DealBuffEventArgs> DealBuffEvent { get; set; }

        EventHandler<TakeDamageEventArgs> TakeDamageEvent { get; set; }
        EventHandler<TakeHealEventArgs> TakeHealEvent { get; set; }
        EventHandler<TakeBuffEventArgs> TakeBuffEvent { get; set; }
    }
}
