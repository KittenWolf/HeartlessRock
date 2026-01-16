using HeartlessRock.Models.Abstractions;

namespace HeartlessRock.Models.Objects;

public abstract class Card : GameObject, ICard
{
    public string Name { get; init; }
    public byte ManaCost { get; protected set; }
    public Rarity Rarity { get; init; }

    [SearchTag] public IHero.HeroClass Class { get; init; }

    public Card(string name, byte manaCost, Rarity.RarityType rarity, IHero.HeroClass @class)
    {
        Name = name;
        ManaCost = manaCost;
        Rarity = new Rarity(rarity);
        Class = @class;

        ObjectType.Add(GameObjectType.Card);
        Status = GameObjectStatus.InDeck;
    }

    public void Destroy()
    {
        Status = GameObjectStatus.Destroyed;
    }

    public void Discard()
    {
        Status = GameObjectStatus.Discarded;
    }

    public int CompareTo(Card other)
    {
        return ManaCost > other.ManaCost ? 1 : -1;
    }
}
