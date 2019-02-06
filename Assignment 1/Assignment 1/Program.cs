using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string firstName;
            string middleInitail;
            string lastName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            Console.Write("What is your first name? ");
            firstName = Console.ReadLine();
            Console.Write("What is your middle initial? ");
            middleInitail = Console.ReadLine();
            Console.Write("What is your last name? ");
            lastName = Console.ReadLine();

            Console.Write("How many feet tall are you? ");
            heightFeet = int.Parse(Console.ReadLine());
            Console.Write("How many remaining inches tall are you? ");
            heightInches = double.Parse(Console.ReadLine());
            totalHeightCM = (heightInches + heightFeet * 12) * 2.54;
                    
            Console.Write("How old are you? ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Are you a US citizen? ");
            isCitizenstring = Console.ReadLine().ToLower();
            bool isCitizen = isCitizenstring.Contains("y") || isCitizenString.Contains("t");
            canVote = age >= 18 && isCitizen;

            Console.WriteLine("Name: " + firstName + " " + middleInitail + ". " + lastName);
            Console.WriteLine("Height: " + totalHeightCM + "cm");
            Console.WriteLine("Able to vote: " + canVote);
            Console.ReadKey();
        }
    }
}
