using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Enumerable;
using System.Text;
using System.Threading.Tasks;
using C.FiddleCollection2;

namespace C.FiddleCollection2
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            zoo.AnimalatZoo.Add(new Animal("Kangaroo", 10));
            zoo.AnimalatZoo.Add(new Animal("Mr Sea Lion", 20));
            foreach (Animal a in zoo.AnimalatZoo) { Console.WriteLine("{0}, {1}", a.Name, a.Popularity); };
            Console.ReadLine();
        }
    }
}
