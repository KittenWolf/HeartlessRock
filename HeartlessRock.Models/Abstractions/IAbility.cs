using HeartlessRock.Models.Abstractions;

namespace HeartlessRock.Models.GameObjects
{
    public interface IAbility
    {
        byte AbilityCost { get; }
        string? AbilityInfo { get; }
        IHero.HeroClass Class { get; }
    }
}