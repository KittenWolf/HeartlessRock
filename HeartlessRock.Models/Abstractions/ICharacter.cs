namespace HeartlessRock.Models.Abstractions
{
    public partial interface ICharacter 
    {
        Health Health { get; protected set; }
        Attack Attack { get; protected set; }

        CharacterCategory Category { get; set; }
        ICollection<CharacterProp> Props { get; set; }

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
            Damaged,
            Frozen,
            Sleep,
        }
    }
    #endregion
}
