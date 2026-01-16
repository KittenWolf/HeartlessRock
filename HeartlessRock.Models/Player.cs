using HeartlessRock.Models.Objects;

namespace HeartlessRock.Models;

public class Player(string name, Deck deck, Hero hero)
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
    private readonly Deck _deck = deck;
    private readonly Hero _hero = hero;

    private byte _fatigue = 1;

    public bool HasMinionsOnBoard => _board.Minions.Count > 0;
    public bool HasCardsInHand => _hand.Cards.Count > 0;
    public bool HasCardsInDeck => _deck.Cards.Count > 0;
}
