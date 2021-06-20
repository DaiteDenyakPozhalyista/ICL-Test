using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    public class Student : Person
    {
        private string group;
        public string Group
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
            }
        }
        public Student(string name, string group) : base(name)
        {
            Group = group;
        }
        public override void Print()
        {
            Console.WriteLine(string.Format("{0} in group {1}", Name, Group));
        }
    }
}
