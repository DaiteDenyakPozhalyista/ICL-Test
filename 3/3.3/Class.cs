using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    public class Class : IDisposable
    {
        public string Name { get; set; }
        public void Dispose()
        {
            Console.Beep();
            Console.WriteLine("Disposed class");
        }
    }
}
