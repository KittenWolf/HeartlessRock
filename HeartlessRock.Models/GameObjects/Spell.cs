using HeartlessRock.Models.GameObjects;

namespace HeartlessRock.Models
{
    public class Spell : Card
    {
        public enum SpellCategory
        {
            Fire,
            Arcane,
            Frost,
            Shadow,
            Holy,
            Nature,
            Fel
        }

        [SearchTag] public SpellCategory Category { get; protected set; }

        public Spell(SpellCategory category, string name, byte manaCost, Rarity.RarityType rarity, Hero.HeroClass @class)
            : base(name, manaCost, rarity, @class)
        {
            Category = category;

            ObjectType.Add(GameObjectType.Spell);
        }
    }
}
