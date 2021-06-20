using System;

namespace _2
{
    public class Except : ArgumentException
    {
        public int Value { get; }
        public Except(string message, int val) : base(message)
        {
            Value = val;
        }
    }
}
