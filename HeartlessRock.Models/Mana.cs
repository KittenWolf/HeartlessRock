namespace HeartlessRock.Models;

public class Mana()
{
    private const byte MaxManaCrystalsLimit = 10;

    public byte EmptyManaCrystals { get; private set; }
    public byte ManaCrystals { get; private set; } = 0;

    public void Refresh()
    {
        ManaCrystals = EmptyManaCrystals;
    }

    public void Get(byte amount)
    {
        if (EmptyManaCrystals < MaxManaCrystalsLimit)
        {
            EmptyManaCrystals += amount;
        }
        else
        {
            EmptyManaCrystals = MaxManaCrystalsLimit;
        }
    }

    public void Spend(byte mana)
    {
        ManaCrystals -= mana;
    }

    public bool IsEnough(byte mana)
    {
        return ManaCrystals - mana >= 0;
    }
}
