using HeartlessRock.Models.Abstractions;

namespace HeartlessRock.Models.Objects;

public abstract class Weapon : Card, IWeapon
{
    public int Attack { get; set; }
    public byte Durability { get; set; }

    [SearchTag] public ICollection<IWeapon.WeaponCategory> Category { get; init; }
    [SearchTag] public ICollection<IWeapon.WeaponEffect> WeaponEffects { get; init; } = [];

    public Weapon(int attack, byte durabiliry, IWeapon.WeaponCategory category, string name, byte manaCost, Rarity.RarityType rarity, IHero.HeroClass @class)
        : base(name, manaCost, rarity, @class)
    {
        Attack = attack;
        Durability = durabiliry;
        Category = [category];

        ObjectType.Add(GameObjectType.Weapon);
    }

    public abstract void SetProp(IWeapon.WeaponEffect prop);
    public abstract void RemoveProp(IWeapon.WeaponEffect prop);
    public abstract void Break();
}
