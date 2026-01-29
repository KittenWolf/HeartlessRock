using HeartlessRock.Models.Abstractions;

namespace HeartlessRock.Models.Objects;

public abstract class Hero : GameObject, IHero
{
    public ushort Armor { get; protected set; } = 0;
    public Attack Attack { get; init; } = new(0);
    public Health Health { get; init; } = new(30);

    public Weapon? Weapon { get; protected set; }
    public Ability? Ability { get; protected set; }
    public ConsoleColor Color => GetColor();

    [SearchTag] public IHero.HeroClass Class { get; init; }
    [SearchTag] public ICollection<ICharacter.CharacterType> Type { get; init; } = [];
    [SearchTag] public ICollection<ICharacter.CharacterEffect> Effects { get; init; } = [];
    [SearchTag] public ICollection<ICharacter.CharacterStatus> Statuses { get; init; } = [];

    public Hero(IHero.HeroClass @class)
    {
        Class = @class;
        Status = GameObjectStatus.OnBoard;

        ObjectType.Add(GameObjectType.Hero);
        ObjectType.Add(GameObjectType.Character);
    }

    private ConsoleColor GetColor()
    {
        return Class switch
        {
            IHero.HeroClass.Druid => ConsoleColor.DarkYellow,
            IHero.HeroClass.Hunter => ConsoleColor.DarkGreen,
            IHero.HeroClass.Mage => ConsoleColor.Cyan,
            IHero.HeroClass.Paladin => ConsoleColor.Magenta,
            IHero.HeroClass.Priest => ConsoleColor.Black,
            IHero.HeroClass.Rouge => ConsoleColor.DarkGray,
            IHero.HeroClass.Shaman => ConsoleColor.DarkBlue,
            IHero.HeroClass.Warlock => ConsoleColor.DarkMagenta,
            IHero.HeroClass.Warrior => ConsoleColor.DarkRed,
            IHero.HeroClass.NoClass => ConsoleColor.Gray,
            _ => ConsoleColor.White,
        };
    }

    public abstract void SetEffect(ICharacter.CharacterEffect effect);
    public abstract void RemoveEffect(ICharacter.CharacterEffect effect);
    public abstract void Die();
    public abstract void DoAttack();
    public abstract void TakeDamage(int damage);
    public abstract void TakeHeal(int health);
    public abstract void UseAbility();
    public abstract void WearWeapon(Weapon weapon);
}
