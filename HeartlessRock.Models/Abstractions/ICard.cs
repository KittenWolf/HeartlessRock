namespace HeartlessRock.Models.Abstractions
{
    internal interface ICard
    {
        string Name { get; init; }
        byte ManaCost { get; }
        Rarity Rarity { get; init; }

        IHero.HeroClass Class { get; init; }

        void Discard();
        void Destroy();
    }
}
