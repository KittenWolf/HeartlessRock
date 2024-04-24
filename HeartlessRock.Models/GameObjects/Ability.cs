namespace HeartlessRock.Models.GameObjects
{
    public class Ability : GameObject
    {
        public bool AbilityIsReady = false;

        [SearchTag] public Hero.HeroClass Class { get; private set; }

        public byte AbilityCost { get; protected set; }
        public string? AbilityInfo { get; protected set; }

        public Ability(Hero.HeroClass @class, byte cost)
        {
            Class = @class;
            AbilityCost = cost;
            Status = GameObjectStatus.OnBoard;

            ObjectType.Add(GameObjectType.Ability);
        }
    }
}
