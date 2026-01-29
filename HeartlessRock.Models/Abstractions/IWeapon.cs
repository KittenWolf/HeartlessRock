namespace HeartlessRock.Models.Abstractions;

public partial interface IWeapon
{
    ICollection<WeaponCategory> Category { get; init; }
    ICollection<WeaponEffect> WeaponEffects { get; init; }

    void SetProp(WeaponEffect effect);
    void RemoveProp(WeaponEffect effect);
    void Break();
}

public partial interface IWeapon
{
    enum WeaponCategory
    {
        Bow,
        Dagger,
        Sword,
        Hummer,
        Shield,
    }

    enum WeaponEffect
    {
        Poison,
        Cleave,
        Piercing,
    }
}
