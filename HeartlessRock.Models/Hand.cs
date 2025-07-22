using HeartlessRock.Models.Objects;

namespace HeartlessRock.Models
{
    public class Hand
    {
        private const int MaxHandSize = 10;

        public List<Card> Cards = new(MaxHandSize);

        public bool HasFreeSpace()
        {
            return Cards.Count < MaxHandSize;
        }

        public void AddCards(List<Card> cards)
        {
            cards.ForEach(AddCard);
        }

        public void AddCard(Card card)
        {
            if (Cards.Count + 1 <= MaxHandSize)
            {
                Cards.Add(card);
            }
            else
            {
                card.Destroy();
            }
        } 

        public Card? GetCard(int index)
        {
            Card? card = null;

            if (index >= 0 && index < Cards.Count)
            {
                card = Cards[index];
                Cards.Remove(card);
            }

            return card;
        }
    }
}
