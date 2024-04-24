using HeartlessRock.Events.Abstractions;

namespace HeartlessRock.Events.PlayerEvents
{
    public class RefreshManaCrystalsEventArgs : PlayerEventArgs
    {
        public RefreshManaCrystalsEventArgs(IEventInitiator initiator) 
            : base(initiator, 1)
        {
            EventTags.Add(EventTag.RefreshMana);
        }
    }
}
