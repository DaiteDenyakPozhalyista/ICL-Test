using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    public class Program
    {
        public void GetValue( int val)
        {
            string s;
            try
            {
                Value v = new Value { EnterValue = val };
            }
            catch (Except ex)
            {
                s = ex.Message + "Enter value = " + ex.Value;
            }
        }

    }
}
