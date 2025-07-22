using HeartlessRock.Models.Abstractions;

namespace HeartlessRock.Models.Objects
{
    public class Spell : Card, ISpell
    {
        [SearchTag] public ISpell.SpellCategory Category { get; init; }

        public Spell(ISpell.SpellCategory category, string name, byte manaCost, Rarity.RarityType rarity, IHero.HeroClass @class)
            : base(name, manaCost, rarity, @class)
        {
            Category = category;

            ObjectType.Add(GameObjectType.Spell);
        }
    }
}
