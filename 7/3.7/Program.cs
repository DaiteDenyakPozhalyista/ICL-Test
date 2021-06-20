using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3._7
{
    class Program
    {
        static void Sym()
        {
            int a = 5;
            int b = 9;
            int sym = a + b;
            Thread.Sleep(6000);//типо долго работает
            Console.WriteLine(sym);
        }
        static async void SymAsync()
        {
            Console.WriteLine("Begin async");
            await Task.Run(() => Sym());
            Console.WriteLine("End async");
        }
        static void Main(string[] args)
        {
            SymAsync();
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());//что-то делает пользователь пока работает другой метод
            Console.WriteLine(string.Format("{0}", n * n));
            Console.ReadKey();
        }
    }
}
