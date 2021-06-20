using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student("Name student", 19);
            var serializer = new XmlSerializer(typeof(Student));
            using (FileStream fileStream = new FileStream("person.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fileStream, stud);
            }
            using (FileStream fileStream = new FileStream("person.xml", FileMode.OpenOrCreate))
            {
                Student newStudent = (Student)serializer.Deserialize(fileStream);
                Console.WriteLine(newStudent.Name + " " + newStudent.Age);
            }
            Console.ReadKey();
        }
    }
}
