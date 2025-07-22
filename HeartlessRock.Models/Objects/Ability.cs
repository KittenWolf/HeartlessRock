using HeartlessRock.Models.Abstractions;

namespace HeartlessRock.Models.Objects
{
    public abstract class Ability : GameObject, IAbility
    {
        public bool AbilityIsReady = false;

        [SearchTag] public IHero.HeroClass Class { get; private set; }

        public byte AbilityCost { get; protected set; }
        public string? AbilityInfo { get; protected set; }

        public Ability(IHero.HeroClass @class, byte cost)
        {
            Class = @class;
            AbilityCost = cost;
            Status = GameObjectStatus.OnBoard;

            ObjectType.Add(GameObjectType.Ability);
        }
    }
}
