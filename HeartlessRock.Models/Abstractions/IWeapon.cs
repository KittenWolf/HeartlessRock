namespace HeartlessRock.Models.Abstractions
{
    public partial interface IWeapon
    {
        WeaponCategory Category { get; init; }

        void SetProp(WeaponProp prop);
        void RemoveProp(WeaponProp prop);
        void Break();
    }

    public partial interface IWeapon
    {
        public enum WeaponCategory
        {
            Bow,
            Dagger,
            Sword,
            Hummer,
            Shield,
        }

        public enum WeaponProp
        {
            Poison,
        }
    }
}
