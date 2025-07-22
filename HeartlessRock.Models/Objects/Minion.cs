using HeartlessRock.Models.Abstractions;
using HeartlessRock.Models.Objects;

namespace HeartlessRock.Models.Objects
{
    public abstract class Minion : Card, IMinion
    {
        public ushort Armor { get; protected set; } = 0;
        public Attack Attack { get; init; }
        public Health Health { get; init; }

        [SearchTag] public ICollection<ICharacter.CharacterProp> Props { get; init; } = [];
        [SearchTag] public ICharacter.CharacterCategory Category { get; init; } = ICharacter.CharacterCategory.NoType;

        public Minion(Attack attack, Health health, string name, byte manaCost, Rarity.RarityType rarity, IHero.HeroClass @class) 
            : base(name, manaCost, rarity, @class)
        {
            Attack = attack;
            Health = health;

            ObjectType.Add(GameObjectType.Minion);
            ObjectType.Add(GameObjectType.Character);
        }

        public abstract void SetProp(ICharacter.CharacterProp prop);
        public abstract void RemoveProp(ICharacter.CharacterProp prop);
        public abstract void Die();
        public abstract void DoAttack();
        public abstract void TakeDamage(int damage);
        public abstract void TakeHeal(int health);
    }
}
