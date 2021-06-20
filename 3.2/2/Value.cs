using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    public class Value
    {
        private int val;
        public int EnterValue
        {
            get { return val; }
            set
            {
                if (value > 5)
                {
                    throw new Except("value > 5", val);
                }
                else
                {
                    val = value;
                }
            }
        }
    }
}
