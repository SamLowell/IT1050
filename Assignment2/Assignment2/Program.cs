using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Person person1 = new Person();
            person1.AskNameAge();
            person1.AskSpouseNameAge();

            Person person2 = new Person();
            person2.AskNameAge();
            person2.AskSpouseNameAge();
            
            person1.PrintNameandAge();
            person1.Spouse.PrintNameandAge();
            person2.PrintNameandAge();
            person2.Spouse.PrintNameandAge();

            Console.WriteLine("");
            double AverageAge = Person.SumOfAges / 4;
            Console.WriteLine("Average Age: " + AverageAge);
            Console.ReadKey();
        }
    }
}
