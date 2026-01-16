using HeartlessRock.Events.Abstractions;
using System.Reflection;
using System.Text;

namespace HeartlessRock.Events;

public abstract class GameEventArgs(IEventInitiator initiator, byte repeats) 
    : EventArgs
{
    [AttributeUsage(AttributeTargets.Field)] protected class EventArg : Attribute;        

    public enum EventTag
    {
        GameEvent,
        StartOfTurn, EndOfTurn,
        
        PlayerEvent,
        DrawCard,
        GetMana,
        RefreshMana,
        PlayCard,
        SummonMinion,
        WearWepon,
        CastSpell,
        
        CharacterEvent,
        TargetableEvent,
        DealHeal, TakeHeal,
        DealDamage, TakeDamage,
        DealBuff, TakeBuff,
        Attack,
        Battlecry,
        Deathrattle
    }

    public byte Repeats { get; set; } = repeats;
    public IEventInitiator Initiator { get; set; } = initiator;
    public ICollection<EventTag> EventTags { get; private set; } = [ EventTag.GameEvent ];

    public new string ToString()
    {
        StringBuilder sb = new();

        sb.Append("Event: ");

        foreach (var tag in EventTags)
        {
            sb.Append($"[{tag}]");    
        }

        Type type = GetType();
        var fields = type.GetFields();

        foreach (var field in fields)
        {
            if (field.GetCustomAttributes<EventArg>().Any())
            {
                sb.Append($" ({field.GetValue(this)})");
            }
        }

        sb.Append($" Initiator: {Initiator}");

        return sb.ToString();
    }
}
