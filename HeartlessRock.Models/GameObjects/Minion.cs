using HeartlessRock.Models.Abstractions;
using HeartlessRock.Models.GameObjects;

namespace HeartlessRock.Models
{
    public class Minion : Card, ICharacter
    {
        public ushort Armor { get; set; }
        public Attack Attack { get; set; }
        public Health Health { get; set; }

        [SearchTag] public ICollection<ICharacter.CharacterProp> Props { get; set; } = [];
        [SearchTag] public ICharacter.CharacterCategory Category { get; set; } = ICharacter.CharacterCategory.NoType;

        public Minion(Attack attack, Health health, string name, byte manaCost, Rarity.RarityType rarity, Hero.HeroClass @class) 
            : base(name, manaCost, rarity, @class)
        {
            Attack = attack;
            Health = health;

            ObjectType.Add(GameObjectType.Minion);
            ObjectType.Add(GameObjectType.Character);
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
