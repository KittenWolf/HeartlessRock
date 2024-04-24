using HeartlessRock.Models.GameObjects;

namespace HeartlessRock.Models
{
    public class Weapon : Card
    {
        public enum WeaponCategory
        {
            Bow,
            Dagger,
            Sword,
            Hummer,
            Shield,
        }

        public int Attack { get; set; }
        public byte Durability { get; set; }

        [SearchTag] public WeaponCategory Category { get; set; }

        public Weapon(int attack, byte durabiliry, WeaponCategory category, string name, byte manaCost, Rarity.RarityType rarity, Hero.HeroClass @class)
            : base(name, manaCost, rarity, @class)
        {
            Attack = attack;
            Durability = durabiliry;
            Category = category;

            ObjectType.Add(GameObjectType.Weapon);
        }
    }
}
