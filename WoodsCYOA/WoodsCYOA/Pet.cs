using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodsCYOA
{
    class Pet
    {
        public string Name;

        public string GetName(string animal)
        {
            Console.WriteLine("");
            Console.WriteLine("What is the " + animal + " name? ");
            return this.Name = Console.ReadLine();
            
        }


    }
}
