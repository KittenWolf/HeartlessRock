namespace HeartlessRock.Models
{
    public class Player(string name, Deck deck)
    {
        public enum PlayerIdentity
        {
            Enemy = 0,
            Friendly = 1,
        }

        private PlayerIdentity _identity;
        private readonly string _name = name;

        private readonly Board _board = new();
        private readonly Mana _mana = new();
        private readonly Hand _hand = new();
        public readonly Deck Deck = deck;
        private readonly Hero _hero = deck.Hero;

        private byte _fatigue = 1;

        public bool HasMinionsOnBoard => _board.Minions.Count > 0;
        public bool HasCardsInHand => _hand.Cards.Count > 0;
        public bool HasCardsInDeck => Deck.Cards.Count > 0;

        public List<GameObject> Objects { get; } = [];

        public void ChangeIdentity()
        {
            if (_identity == PlayerIdentity.Enemy)
            {
                SetIdentity(PlayerIdentity.Friendly);
            }
            else
            {
                SetIdentity(PlayerIdentity.Enemy);
            }
        }

        public void SetIdentity(PlayerIdentity owner)
        {
            _identity = owner;
            Objects.ForEach(obj => obj.SetIdentity(_identity));
        }
    }
}
