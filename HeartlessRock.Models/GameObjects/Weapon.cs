using HeartlessRock.Models.Abstractions;
using HeartlessRock.Models.GameObjects;

namespace HeartlessRock.Models
{
    public abstract class Weapon : Card, IWeapon
    {
        public int Attack { get; set; }
        public byte Durability { get; set; }

        [SearchTag] public IWeapon.WeaponCategory Category { get; init; }

        public Weapon(int attack, byte durabiliry, IWeapon.WeaponCategory category, string name, byte manaCost, Rarity.RarityType rarity, IHero.HeroClass @class)
            : base(name, manaCost, rarity, @class)
        {
            Attack = attack;
            Durability = durabiliry;
            Category = category;

            ObjectType.Add(GameObjectType.Weapon);
        }

        public abstract void SetProp(IWeapon.WeaponProp prop);
        public abstract void RemoveProp(IWeapon.WeaponProp prop);
        public abstract void Break();
    }
}
