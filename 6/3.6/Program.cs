using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Task[] t = new Task[4];
            int a = 0;
            int b = 0;
            int c = 0;
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = Task.Run(() => Console.WriteLine(string.Format("a={0}, b={1}, c={2}", a += 1, b += 3, c += 10)));
            }

            var first = Task.Run(() =>
            {
                Console.WriteLine("First");
                var second = Task.Run(() =>
                {
                    Console.WriteLine("Second");
                    //Thread.Sleep(2000);
                    Console.WriteLine("Second end");
                });
            });
            first.Wait();
            Console.WriteLine("All End");
            Console.ReadLine();
        }
    }
}
