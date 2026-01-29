namespace HeartlessRock.Models.Abstractions;

public partial interface ICharacter
{
    ushort Armor { get; }
    Health Health { get; init; }
    Attack Attack { get; init; }

    ICollection<CharacterType> Type { get; init; }
    ICollection<CharacterEffect> Effects { get; init; }
    ICollection<CharacterStatus> Statuses { get; init; }

    void SetEffect(CharacterEffect effect);
    void RemoveEffect(CharacterEffect effect);
    void Die();
    void DoAttack();
    void TakeDamage(int value);
    void TakeHeal(int value);
}

public partial interface ICharacter
{
    enum CharacterType
    {
        NoType,
        Beast,
        BloodElf,
        Building,
        Demon,
        Elemental,
        Human,
        Mech,
        Murloc,
        NightElf,
        Orc,
        Ogre,
        Pirate
    }

    enum CharacterEffect
    {
        NoEffect,
        BKB,
        Charge,
        DivineShield,
        Enrage,
        Rush,
        Stealth,
        Taunt,
        Windfury,
    }

    enum CharacterStatus
    {
        ReadyToAttack,
        Attacked,
        AlreadyAttacked,
        Damaged,
        Frozen,
        Sleep,
        Bleeding,
    }
}
