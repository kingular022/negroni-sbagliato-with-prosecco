namespace _20._10.Serwisy.lab2
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
            Value += value;
        }

        public void Decrease(int value)
        {
            Value -= value;
        }

        public int GetValue()
        {
            return Value;
        }
    }
}
