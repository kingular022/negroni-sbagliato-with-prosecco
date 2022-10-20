namespace _20._10.Controllers.Serwisy
{
    public class Calculate
    {
        public Calculate(int initVal)
        {
            Value = initVal;
        }

        private int Value { get; set; }

        public void Increase(int value)
        {
            this.Value += value;
        }

        public void Decrease(int value)
        {
            this.Value -= value;
        }

        public int GetValue()
        {
            return Value;
        }
    }
}
