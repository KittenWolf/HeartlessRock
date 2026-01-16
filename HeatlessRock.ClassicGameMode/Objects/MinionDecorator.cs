using HeartlessRock.ClassicGameMode.Events;
using HeartlessRock.Events.CharacterEvents;
using HeartlessRock.Events.CharacterEvents.TargetableEvents;
using HeartlessRock.Models;
using HeartlessRock.Models.Abstractions;
using HeartlessRock.Models.Objects;

namespace HeartlessRock.ClassicGameMode.Objects;

internal partial class MinionDecorator(Attack attack, Health health, string name, byte manaCost, Rarity.RarityType rarity, IHero.HeroClass @class) 
    : Minion(attack, health, name, manaCost, rarity, @class), ICharacterEvents
{
    public override void Die()
    {
        throw new NotImplementedException();
    }

    public override void DoAttack()
    {
        throw new NotImplementedException();
    }

    public override void RemoveProp(ICharacter.CharacterProp prop)
    {
        throw new NotImplementedException();
    }

    public override void SetProp(ICharacter.CharacterProp prop)
    {
        throw new NotImplementedException();
    }

    public override void TakeDamage(int damage)
    {
        throw new NotImplementedException();
    }

    public override void TakeHeal(int health)
    {
        throw new NotImplementedException();
    }
}

internal partial class MinionDecorator
{
    public EventHandler<AttackEventArgs> AttackEvent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public EventHandler<DealDamageEventArgs> DealDamageEvent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public EventHandler<DealHealEventArgs> DealHealEvent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public EventHandler<DealBuffEventArgs> DealBuffEvent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public EventHandler<TakeDamageEventArgs> TakeDamageEvent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public EventHandler<TakeHealEventArgs> TakeHealEvent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public EventHandler<TakeBuffEventArgs> TakeBuffEvent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
