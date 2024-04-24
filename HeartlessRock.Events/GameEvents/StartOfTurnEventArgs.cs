using HeartlessRock.Events.Abstractions;

namespace HeartlessRock.Events.GameEvents
{
    public class StartOfTurnEventArgs : GameEventArgs
    {
        [EventArg] public readonly byte Turn;

        public StartOfTurnEventArgs(byte turn, IEventInitiator initiator, byte repeats)
            : base(initiator, repeats)
        {
            Turn = turn;
            EventTags.Add(EventTag.StartOfTurn);
        }
    }
}
