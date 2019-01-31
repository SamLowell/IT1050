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

            System.Console.Write("What is your first name? ");
            firstName = System.Console.ReadLine();
            System.Console.Write("What is your middle initial? ");
            middleInitail = System.Console.ReadLine();
            System.Console.Write("What is your last name? ");
            lastName = System.Console.ReadLine();

            System.Console.Write("How many feet tall are you? ");
            heightFeet = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many remaining inches tall are you? ");
            heightInches = double.Parse(System.Console.ReadLine());
            totalHeightCM = (heightInches + heightFeet * 12) * 2.54;
           
            System.Console.Write("How old are you? ");
            age = int.Parse(System.Console.ReadLine());
            System.Console.Write("You are a US citizen.  True or False? ");
            isCitizen = bool.Parse(System.Console.ReadLine());
            canVote = age >= 18 && isCitizen;

            System.Console.WriteLine("Name: " + firstName + " " + middleInitail + ". " + lastName);
            System.Console.WriteLine("Height: " + totalHeightCM + "cm");
            System.Console.WriteLine("Able to vote: " + canVote);
            System.Console.ReadKey();
        }
    }
}
