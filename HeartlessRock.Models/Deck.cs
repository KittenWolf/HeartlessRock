using HeartlessRock.Models.Abstractions;
using HeartlessRock.Models.Objects;

namespace HeartlessRock.Models
{
    public class Deck(string name, IHero.HeroClass hero)
    {
        private const int MaxDeckSize = 30;

        public readonly string Name = name;
        public readonly IHero.HeroClass Class = hero;

        public List<Card> Cards { get; } = new(MaxDeckSize);

        public void AddCard(Card card)
        {
            if (card.Class == Class)
            {
                Cards.Add(card);
            }
            else
            {
                throw new Exception("You can not add a card with different hero class");
            }
        }

        public void RemoveCard(Card card)
        {
            Cards.Remove(card);
        }

        public Card? GetCard()
        {
            Card? card = null;

            if (Cards.Count > 0)
            {
                var index = new Random().Next(Cards.Count);
                card = Cards[index];
                card.Status = GameObject.GameObjectStatus.InHand;

                RemoveCard(Cards[index]);
            } 

            return card;
        }

        public List<Card> GetCards(byte cards)
        {
            List<Card> list = [];

            for (int i = 0; i < cards; i++)
            {
                var card = GetCard();

                if (card == null)
                {
                    break;
                }
                
                list.Add(card);
            }

            return list;
        }

        public Card? PeekCard()
        {
            if (Cards.Count > 0)
            {
                var index = new Random().Next(Cards.Count);
                return Cards[index];
            }

            return null;
        }
    }
}
