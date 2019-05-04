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
                    TotalCost += numberTickets * Prices.MatineeAdult;
                }
                asknumberTickets("seniors");
                if (numberTickets >= 1)
                {
                    TotalnumberTickets += numberTickets;
                    TotalCost += numberTickets * Prices.MatineeSenior;
                }
                asknumberTickets("children");
                if (numberTickets >= 1)
                {
                    TotalnumberTickets += numberTickets;
                    TotalCost += numberTickets * Prices.MatineeChild;
                }
            }
            else 
            {
                asknumberTickets("adults");
                if (numberTickets >= 1)
                {
                    TotalnumberTickets += numberTickets;
                    TotalCost += numberTickets * Prices.EveningAdult;
                }
                asknumberTickets("seniors");
                if (numberTickets >= 1)
                {
                    TotalnumberTickets += numberTickets;
                    TotalCost += numberTickets * Prices.EveningSenior;
                }
                asknumberTickets("children");
                if (numberTickets >= 1)
                {
                    TotalnumberTickets += numberTickets;
                    TotalCost += numberTickets * Prices.EveningChild;
                }
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
                    TotalCost += numberConcessions * Prices.LargeSoda;
                }
                asknumberConcessions("small sodas");
                if (numberConcessions >= 1)
                {
                    TotalCost += numberConcessions * Prices.SmallSoda;
                }
                asknumberConcessions("hot dogs");
                if (numberConcessions >= 1)
                {
                    TotalCost += numberConcessions * Prices.HotDog;
                }
                asknumberConcessions("bags of popcorn");
                if (numberConcessions >= 1)
                {
                    TotalPopcorn += numberConcessions;
                    TotalCost += numberConcessions * Prices.Popcorn;
                }
                asknumberConcessions("candies");
                if(numberConcessions >= 1)
                {
                    TotalCandies += numberConcessions;
                    TotalCost += numberConcessions * Prices.Candies;
                }
            }

            
            if (TotalPopcorn >=1 && TotallrgSoda >=1 && TotalnumberTickets >=1)
            {
                if(TotalPopcorn < TotallrgSoda && TotalPopcorn < TotalnumberTickets)
                {
                    TotalCost -= TotalPopcorn * Prices.Discount1;
                }
                else if (TotallrgSoda < TotalPopcorn && TotallrgSoda < TotalnumberTickets)
                {
                    TotalCost -= TotallrgSoda * Prices.Discount1;
                }
                else
                {
                    TotalCost -= TotalnumberTickets * Prices.Discount1;
                }
            }
            
            if (time.ToLower().Contains("evening") && TotalnumberTickets >=3 && TotalPopcorn >=1)
            {
                TotalCost -= Prices.Popcorn;
            }
            
            if (TotalCandies >= 4)
            {
                double discount = (TotalCandies / 4) * Prices.Candies;
                TotalCost -= discount;
            }

            Console.WriteLine("Your total come to: $" + TotalCost);
            Console.ReadKey();

            }
    }
}
