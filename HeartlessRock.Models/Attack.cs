namespace HeartlessRock.Models
{
    public class Attack
    {
        private readonly int _default;

        public int Current;

        public Attack(int attack)
        {
            _default = Current = attack;
        }

        public void GetBuff(int value) 
        {
            Current += value;
        }

        public void Reset() 
        {
            Current = _default;
        }

        public void Set(int value) 
        {
            Current = value;
        }
    }
}
