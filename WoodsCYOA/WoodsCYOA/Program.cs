using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodsCYOA
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet dog = new Pet();
            Pet cat = new Pet();

            Console.WriteLine("You are walking on a path in the woods.");
            System.Console.ReadKey();
            Console.WriteLine("Ahead of you there is a dog and a cat.");
            System.Console.ReadKey();
            Console.Write("What is the dog's name? ");
            dog.Name = Console.ReadLine();

            Console.Write("What is the cat's name? ");
            cat.Name = Console.ReadLine();            

            Console.WriteLine(dog.Name + " and " + cat.Name + " head in opposite directions.");
            //Reader chooses animal to follow once I learn how to do that.
            System.Console.ReadKey();
            Console.WriteLine("Will you follow:");
            Console.WriteLine(dog.Name + "?");
            Console.WriteLine(cat.Name + "?");
            Console.ReadKey();
            
            
        }
    }
}
