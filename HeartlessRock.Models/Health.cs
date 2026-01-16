namespace HeartlessRock.Models;

public class Health
{
    private readonly int _default;
    private int _max;

    public int Current;

    public Health(int health)
    {
        _default = Current = _max = health;
    }

    public void TakeDamage(int value)
    {
        Current -= value;
    }

    public void Set(int value)
    {
        Current = _max = value;
    }

    public void Reset()
    {
        _max = Current = _default;
    }

    public bool IsFull()
    {
        return Current < _max;
    }

    public void GetBuff(int value)
    {
        Current += value;
        _max += value;
    }

    public void Restore(int value)
    {
        Current += value;

        if (Current > _max)
            Current = _max;
    }
}
