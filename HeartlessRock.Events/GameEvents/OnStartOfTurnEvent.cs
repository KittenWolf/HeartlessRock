using HeartlessRock.Events.Abstractions;

namespace HeartlessRock.Events.GameEvents;

public class OnStartOfTurnEvent(IEventInitiator initiator, byte repeats)
        : GameEventArgs(initiator, repeats)
{
}
