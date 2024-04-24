using HeartlessRock.Models.Abstractions;
using HeartlessRock.Models.GameObjects;

namespace HeartlessRock.Models
{
    public class Hero : GameObject, ICharacter
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

        public ushort Armor { get; set; } = 0;
        public Attack Attack { get; set; } = new(0);
        public Health Health { get; set; } = new(30);

        public Weapon? Weapon { get; set; }
        public Ability? Ability { get; set; }
        public ConsoleColor Color => GetColor();

        [SearchTag] public HeroClass Class { get; set; }
        [SearchTag] public ICollection<ICharacter.CharacterProp> Props { get; set; } = [];
        [SearchTag] public ICharacter.CharacterCategory Category { get; set; } = ICharacter.CharacterCategory.NoType;

        public Hero(HeroClass @class)
        {
            Class = @class;
            Status = GameObjectStatus.OnBoard;

            ObjectType.Add(GameObjectType.Hero);
            ObjectType.Add(GameObjectType.Character);
        }

        private ConsoleColor GetColor()
        {
            return Class switch
            {
                HeroClass.Druid => ConsoleColor.DarkYellow,
                HeroClass.Hunter => ConsoleColor.DarkGreen,
                HeroClass.Mage => ConsoleColor.Cyan,
                HeroClass.Paladin => ConsoleColor.Magenta,
                HeroClass.Priest => ConsoleColor.Black,
                HeroClass.Rouge => ConsoleColor.DarkGray,
                HeroClass.Shaman => ConsoleColor.DarkBlue,
                HeroClass.Warlock => ConsoleColor.DarkMagenta,
                HeroClass.Warrior => ConsoleColor.DarkRed,
                HeroClass.NoClass => ConsoleColor.Gray,
                _ => ConsoleColor.White,
            };
        }

        public void SetProp(ICharacter.CharacterProp prop)
        {
        }

        public void RemoveProp(ICharacter.CharacterProp prop)
        {
        }

        public void Die()
        {
        }

        public void DoAttack()
        {
        }

        public void TakeDamage(int damage)
        {
        }

        public void TakeHeal(int health)
        {
        }
    }
}
