using HeartlessRock.Events.Abstractions;
using HeartlessRock.Models.Objects;

namespace HeartlessRock.Events.PlayerEvents;

public class WearWeaponEventArgs : PlayCardEventArgs
{
    public WearWeaponEventArgs(Weapon weapon, IEventInitiator initiator, byte repeats)
        : base(weapon, initiator, repeats)
    {
        EventTags.Add(EventTag.WearWepon);
    }
}
