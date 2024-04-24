namespace HeartlessRock.Models
{
    public class Rarity(Rarity.RarityType type)
    {
        public enum RarityType
        {
            CommonCard,
            RareCard,
            EpicCard,
            LegendaryCard,
            Uncraftable,
        }

        public ConsoleColor Color => GetColor();
        public int DustCost => GetCost();

        public RarityType Type { get; } = type;

        private ConsoleColor GetColor()
        {
            return Type switch
            {
                RarityType.CommonCard => ConsoleColor.Gray,
                RarityType.RareCard => ConsoleColor.DarkBlue,
                RarityType.EpicCard => ConsoleColor.Magenta,
                RarityType.LegendaryCard => ConsoleColor.DarkYellow,
                _ => ConsoleColor.White,
            };
        }

        private int GetCost()
        {
            return Type switch
            {
                RarityType.CommonCard => 40,
                RarityType.RareCard => 100,
                RarityType.EpicCard => 400,
                RarityType.LegendaryCard => 1600,
                _ => 0,
            };
        }
    }
}
