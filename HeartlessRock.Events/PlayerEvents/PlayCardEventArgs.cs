using HeartlessRock.Events.Abstractions;
using HeartlessRock.Models.GameObjects;

namespace HeartlessRock.Events.PlayerEvents
{
    public abstract class PlayCardEventArgs : PlayerEventArgs
    {
        [EventArg] public readonly Card Card;

        public PlayCardEventArgs(Card card, IEventInitiator initiator, byte repeats) 
            : base(initiator, repeats)
        {
            Card = card;
            EventTags.Add(EventTag.PlayCard);
        }
    }
}
