using System.Collections;
using System.Reflection;

namespace HeartlessRock.Models;

public abstract class GameObject
{
    [AttributeUsage(AttributeTargets.Property)] protected class SearchTag : Attribute;

    public enum GameObjectStatus
    {
        Destroyed,
        Discarded,
        Died,
        Casted,
        InDeck,
        InHand,
        OnBoard,
    }

    public enum GameObjectType
    {
        Card,
        Character,
        Hero,
        Minion,
        Spell,
        Weapon,
        Ability,
        Player,
    }

    private readonly ICollection<Enum> _tags = [];

    [SearchTag] public Player.PlayerIdentity Owner { get; protected set; }
    [SearchTag] public GameObjectStatus Status { get; set; }
    [SearchTag] public ICollection<GameObjectType> ObjectType { get; protected set; } = [];

    public void Init()
    {
        InitTags(this);
    }

    #region Tags
    private void InitTags(object obj)
    {
        Type type = obj.GetType();
        PropertyInfo[] props = type.GetProperties();

        foreach (PropertyInfo prop in props)
        {
            if (prop.GetCustomAttributes<SearchTag>().Any())
            {
                if (prop.PropertyType.IsValueType)
                {
                    AddTag((Enum)prop.GetValue(this));
                }

                if (prop.PropertyType.IsGenericType)
                {
                    AddTags((ICollection)prop.GetValue(this));
                }
            }
        }
    }

    public virtual void SetIdentity(Player.PlayerIdentity owner)
    {
        RemoveTag(Owner);
        AddTag(owner);

        Owner = owner;
    }

    public bool FindTags(ICollection<Enum> list)
    {
        foreach (Enum tag in list)
        {
            if (!_tags.Contains(tag))
            {
                return false;
            }
        }

        return true;
    }

    public void AddTag(Enum @enum)
    {
        if (!_tags.Contains(@enum))
        {
            _tags.Add(@enum);
        }
    }

    public void AddTags(ICollection collection)
    {
        foreach (var item in collection)
        {
            AddTag((Enum)item);
        }
    }

    public void RemoveTag(Enum @enum)
    {
        _tags.Remove(@enum);
    }
    #endregion
}
