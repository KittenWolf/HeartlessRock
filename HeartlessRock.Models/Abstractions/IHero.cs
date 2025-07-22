using HeartlessRock.Models.Objects;

namespace HeartlessRock.Models.Abstractions
{
    public partial interface IHero : ICharacter
    {
        Weapon? Weapon { get; }
        Ability? Ability { get; }

        void UseAbility();
        void WearWeapon(Weapon weapon);
    }

    public partial interface IHero
    {
        public enum HeroClass
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
}
