using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _3._5
{
    [Serializable]
    public class Student
    {
        
        [XmlElement]public string Name { get; set; }
        [XmlElement]public int Age { get; set; }
        public Student() { }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
