using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _3._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"txt.txt";
            string[] lines = File.ReadAllLines(path);
            for (int i = 1; i <= 5; i++)
            {
                File.WriteAllLines(path, lines.Skip(i));
            }
        }
    }
}
