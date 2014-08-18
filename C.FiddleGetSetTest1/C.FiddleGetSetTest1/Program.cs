using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C.FiddleGetSetTest1;

namespace C.FiddleGetSetTest1
{
    public class Student
    {
        /// <summary>
        /// simple get set test where fields are marked private
        /// </summary>
        private int _age = 21;
        public Student(int age) { _age = age; }
        public int Age
        {
            get{return _age;}
            set { _age = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(22);
            int nextAge = s.Age;
            Console.WriteLine(s.Age); // returns 22
            Console.ReadLine();
            s.Age = 23;
            Console.WriteLine(nextAge); //returns 22
            Console.ReadLine();
            Console.WriteLine(s.Age); // returns 23, creates a new reference for object
            Console.ReadLine();
            Console.WriteLine(nextAge);// returns 22
            Console.ReadLine();
        }
    }
}
