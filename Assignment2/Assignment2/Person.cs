using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;
                
        public static double SumOfAges;
            
                
        public void AskNameAge()
        {
            Console.Write("What is your first name? ");
            this.FirstName = Console.ReadLine();
            Console.Write("What is your last name? ");
            this.LastName = Console.ReadLine();
            Console.Write("How old are you? ");
            this.Age = int.Parse(Console.ReadLine());
            SumOfAges += this.Age;

        }

        public void AskSpouseNameAge()
        {
            Spouse = new Person();
            Console.Write("If married what is your spouses name? ");
            Spouse.FirstName = Console.ReadLine();
            Spouse.LastName = LastName;
            Console.Write("How old is your spouse? ");
            Spouse.Age = int.Parse(Console.ReadLine());
            SumOfAges += Spouse.Age;
            
        }
            
        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName + " ";

        }
                                       
        public void PrintNameandAge()
        {
            Console.WriteLine("");
            Console.WriteLine(GetFullName());
            Console.WriteLine(this.Age);
        }

        
    }
}
