using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "Когда соседский кот узнал, что рыжего котёнка зовут Гав"+
                             ", он почесал спинку о трубу соседского дома и сказал:" +
                             "— Я бы не советовал котёнку с таким именем спускаться во двор." +
                             "Во дворе котёнка с таким именем ждут одни неприятности.т",
                             "When the neighbor's cat found out that the red kitten's name was Woof,"+
                             " he scratched his back against the chimney of the neighbor's house and said:"+
                             "— I would not advise a kitten with that name to go down into the yard." +
                             "In the yard, a kitten with that name is waiting for some trouble." };

            using (StreamWriter writer = new StreamWriter(@"txt.txt", false, Encoding.GetEncoding("CP866")))
            {
                foreach (string s in str)
                {
                    writer.WriteLine(s);
                }
            }
            using (StreamReader reader = new StreamReader(@"txt.txt", Encoding.GetEncoding("CP866")))
            {
                string file = reader.ReadToEnd();
                Console.WriteLine(file);
            }
            Console.WriteLine();

            using (StreamWriter writer = new StreamWriter(@"txt1.txt", false, Encoding.GetEncoding("koi8")))
            {
                foreach (string s in str)
                {
                    writer.WriteLine(s);
                }
            }
            using (StreamReader reader = new StreamReader(@"txt1.txt", Encoding.GetEncoding("koi8")))
            {
                string file = reader.ReadToEnd();
                Console.WriteLine(file);
            }
            Console.WriteLine();

            using (StreamWriter writer = new StreamWriter(@"txt2.txt", false, Encoding.GetEncoding("Windows-1251")))
            {
                foreach (string s in str)
                {
                    writer.WriteLine(s);
                }
            }
            using (StreamReader reader = new StreamReader(@"txt2.txt", Encoding.GetEncoding("Windows-1251")))
            {
                string file = reader.ReadToEnd();
                Console.WriteLine(file);
            }
            Console.WriteLine();


            using (StreamWriter writer = new StreamWriter(@"txt3.txt", false, Encoding.UTF8))
            {
                foreach (string s in str)
                {
                    writer.WriteLine(s);
                }
            }
            using (StreamReader reader = new StreamReader(@"txt3.txt", Encoding.UTF8))
            {
                string file = reader.ReadToEnd();
                Console.WriteLine(file);
            }
            Console.WriteLine();
            using (StreamWriter writer = new StreamWriter(@"txt4.txt"))
            {
                foreach (string s in str)
                {
                    writer.WriteLine(s);
                }
            }
            using (StreamReader reader = new StreamReader(@"txt4.txt"))
            {
                string file = reader.ReadToEnd();
                Console.WriteLine(file);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
