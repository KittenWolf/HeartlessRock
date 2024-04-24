namespace HeartlessRock.Models
{
    public class Board
    {
        private const int MaxBoardSize = 7;

        public List<Minion> Minions = new(MaxBoardSize);

        public bool HasFreeSpace()
        {
            return Minions.Count < MaxBoardSize;
        }

        public void SummonMinion(Minion minion)
        {
            if (Minions.Count < MaxBoardSize)
            {
                Minions.Add(minion);
            }
        }
    }
}
