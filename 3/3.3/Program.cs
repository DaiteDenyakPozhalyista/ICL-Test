using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            using(Class cl = new Class { Name = "Name"})
            {
                //some operations with the cl
            }
            Console.ReadKey();
        }
    }
}
