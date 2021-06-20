using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] mas = new string[1,5];
            Student s1 = new Student("Иванов","1");
            Student s2 = new Student("Иванов2","1");
            Student s3 = new Student("Иванов3","1");
            Student s4 = new Student("Иванов4","1");
            Student s5 = new Student("Иванов5","1");
            Teacher t1 = new Teacher("Преподаватель1", "1", "Дисциплина1");
            t1.SetStudents(s1);
            t1.SetStudents(s2);
            t1.SetStudents(s3);
            t1.SetStudents(s4);
            t1.SetStudents(s5);
            t1.Print();
            Console.WriteLine();
            Console.WriteLine(t1.ToString());
            Console.ReadKey();
        }
    }
}
