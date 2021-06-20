using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    public class Person
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Person(string name)
        {
            Name = name;
        }
        public virtual void Print()
        {
            Console.WriteLine(Name);
        }
    }
}
