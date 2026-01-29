using HeartlessRock.Models.Objects;

namespace HeartlessRock.Models.Abstractions;

public partial interface IHero : ICharacter
{
    IWeapon? Weapon { get; }
    Ability? Ability { get; }

    void UseAbility();
    void WearWeapon(IWeapon weapon);
}

public partial interface IHero
{
    enum HeroClass
    {
        Druid,
        Hunter,
        Mage,
        Paladin,
        Priest,
        Rouge,
        Shaman,
        Warlock,
        Warrior,
        NoClass,
    }
}
