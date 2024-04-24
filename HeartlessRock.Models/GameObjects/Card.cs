namespace HeartlessRock.Models.GameObjects
{
    public abstract class Card : GameObject
    {
        public string Name { get; set; }
        public byte ManaCost { get; set; }
        public Rarity Rarity { get; set; }

        [SearchTag] public Hero.HeroClass Class { get; set; }

        public Card(string name, byte manaCost, Rarity.RarityType rarity, Hero.HeroClass @class)
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

        public int CompareTo(Card other)
        {
            return ManaCost > other.ManaCost ? 1 : -1;
        }
    }
}
