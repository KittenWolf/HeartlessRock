namespace HeartlessRock.Models.Abstractions;

public interface IAbility
{
    byte AbilityCost { get; }
    string? AbilityInfo { get; }
    IHero.HeroClass Class { get; }
}