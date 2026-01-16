namespace HeartlessRock.Models.Abstractions;

public partial interface ICharacter
{
    ushort Armor { get; }
    Health Health { get; init; }
    Attack Attack { get; init; }

    CharacterCategory Category { get; init; }
    ICollection<CharacterProp> Props { get; init; }

    void SetProp(CharacterProp prop);
    void RemoveProp(CharacterProp prop);
    void Die();
    void DoAttack();
    void TakeDamage(int value);
    void TakeHeal(int value);
}

#region enums
public partial interface ICharacter
{
    public enum CharacterCategory
    {
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
        Pirate,
        NoType,
    }

    public enum CharacterProp
    {
        BKB,
        Charge,
        DivineShield,
        Enrage,
        Rush,
        Stealth,
        Taunt,
        Windfury,
    }

    public enum CharacterStatus
    {
        Attacked,
        NotAttacked,
        CanAttack,
        Damaged,
        Frozen,
        Sleep,
    }
}
#endregion
