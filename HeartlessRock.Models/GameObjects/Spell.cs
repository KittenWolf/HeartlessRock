using HeartlessRock.Models.Abstractions;
using HeartlessRock.Models.GameObjects;

namespace HeartlessRock.Models
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
