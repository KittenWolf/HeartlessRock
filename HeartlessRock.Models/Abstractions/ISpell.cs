namespace HeartlessRock.Models.Abstractions
{
    public partial interface ISpell
    {
        SpellCategory Category { get; init; }
    }

    public partial interface ISpell
    {
        public enum SpellCategory
        {
            Fire,
            Arcane,
            Frost,
            Shadow,
            Holy,
            Nature,
            Fel
        }
    }
}
