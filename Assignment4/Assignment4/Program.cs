using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            double TotalCost = 0;
            int numberTickets;
            int TotalnumberTickets = 0;
            
            Console.WriteLine("Are you seeing a matinee or evening movie?");
            string time;
            time = Console.ReadLine();
           
             int asknumberTickets(string age)
            {
                Console.WriteLine("How many " + age + "? ");
                numberTickets =  int.Parse(Console.ReadLine());
                return numberTickets;
            }


            if (time.ToLower().Contains("matinee"))       
            {
                asknumberTickets("adults");
                if (numberTickets >= 1)
                {
                    TotalnumberTickets += numberTickets;
                    TotalCost += numberTickets * 5.99;
                }
                asknumberTickets("seniors");
                if (numberTickets >= 1)
                {
                    TotalnumberTickets += numberTickets;
                    TotalCost += numberTickets * 4.50;
                }
                asknumberTickets("children");
                if (numberTickets >= 1)
                {
                    TotalnumberTickets += numberTickets;
                    TotalCost += numberTickets * 3.99;
                }
            }
            else if (time.ToLower().Contains("evening"))
            {
                asknumberTickets("adults");
                if (numberTickets >= 1)
                {
                    TotalnumberTickets += numberTickets;
                    TotalCost += numberTickets * 10.99;
                }
                asknumberTickets("seniors");
                if (numberTickets >= 1)
                {
                    TotalnumberTickets += numberTickets;
                    TotalCost += numberTickets * 8.50;
                }
                asknumberTickets("children");
                if (numberTickets >= 1)
                {
                    TotalnumberTickets += numberTickets;
                    TotalCost += numberTickets * 6.99;
                }
            }
            else
            {
                Console.WriteLine("User Error.  Please try again.");
            }
                               
            int TotalPopcorn = 0;
            int TotallrgSoda = 0;
            int TotalCandies = 0;
            int numberConcessions;

            int asknumberConcessions(string food)
            {
                Console.WriteLine("How many " + food + " would you like? ");
                numberConcessions = int.Parse(Console.ReadLine());
                return numberConcessions;
            }

            Console.WriteLine("Would you like anything from the concession stand? ");
            string concession = Console.ReadLine();
            if (concession.ToLower().Contains("y"))
            {
                asknumberConcessions("large sodas");
                if (numberConcessions >= 1)
                {
                    TotallrgSoda += numberConcessions;
                    TotalCost += numberConcessions * 5.99;
                }
                asknumberConcessions("small sodas");
                if (numberConcessions >= 1)
                {
                    TotalCost += numberConcessions * 3.50;
                }
                asknumberConcessions("hot dogs");
                if (numberConcessions >= 1)
                {
                    TotalCost += numberConcessions * 3.99;
                }
                asknumberConcessions("bags of popcorn");
                if (numberConcessions >= 1)
                {
                    TotalPopcorn += numberConcessions;
                    TotalCost += numberConcessions * 4.50;
                }
                asknumberConcessions("candies");
                if(numberConcessions >= 1)
                {
                    TotalCandies += numberConcessions;
                    TotalCost += numberConcessions * 1.99;
                }
            }

            //Discounts
            ////popcorn and large soda and movie ticket = -$2
            if (TotalPopcorn >=1 && TotallrgSoda >=1 && TotalnumberTickets >=1)
            {
                if(TotalPopcorn < TotallrgSoda && TotalPopcorn < TotalnumberTickets)
                {
                    TotalCost -= TotalPopcorn * 2;
                }
                else if (TotallrgSoda < TotalPopcorn && TotallrgSoda < TotalnumberTickets)
                {
                    TotalCost -= TotallrgSoda * 2;
                }
                else
                {
                    TotalCost -= TotalnumberTickets * 2;
                }
            }
            /// evening tickets >= 3 and popcorn>=1  -$4.50
            if (time.ToLower().Contains("evening") && TotalnumberTickets >=3 && TotalPopcorn >=1)
            {
                TotalCost -= 4.5;
            }
            /// (#of candies/4) * 1.99
            if (TotalCandies >= 4)
            {
                double discount = (TotalCandies / 4) * 1.99;
                TotalCost -= discount;
            }

            Console.WriteLine("Your total come to: $" + TotalCost);
            Console.ReadKey();
        }
    }
}
