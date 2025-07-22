using HeartlessRock.Events.PlayerEvents;

namespace HeartlessRock.ClassicGameMode.Events
{
    internal interface IPlayerEvents
    {
        EventHandler<PlayCardEventArgs> PlayCardEvent { get; set; }
        EventHandler<CastSpellEventArgs> CastSpellEvent { get; set; }
        EventHandler<SummonMinionEventArgs> SummonMinionEvent { get; set; }
        EventHandler<WearWeaponEventArgs> WearWeaponEvent { get; set; }

        EventHandler<GetManaCrystalsEventArgs> GetManaCrystalEvent { get; set; }
        EventHandler<RefreshManaCrystalsEventArgs> RefreshManaCrystalsEvent { get; set; }
        EventHandler<DrawCardEventArgs> DrawCardEvent { get; set; }
    }
}
