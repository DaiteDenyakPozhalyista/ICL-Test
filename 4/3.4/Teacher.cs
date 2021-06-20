using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    public class Teacher : Student
    {
        private string discipline;
        public List<Student> list = new List<Student>();
        private List<Student> List
        {
            get
            {
                return list;
            }
            set
            {
                list = value;
            }
        }
        public string Discipline
        {
            get
            {
                return discipline;
            }
            set
            {
                discipline = value;
            }
        }
        public Teacher(string name, string group, string discipline) : base(name, group)
        {
            Discipline = discipline;
        }
        public void SetStudents(Student stud)
        {
            List.Add(stud);
        }
        public override string ToString()
        {
            return Name + " group: " + Group +" disciplie - "+ Discipline;
        }
        public override void Print()
        {
            Console.WriteLine(Name);
            foreach (Student s in List)
            {
                Console.WriteLine(string.Format("\t student: {0}, group - {1}", s.Name, s.Group));
            }
        }
    }
}
