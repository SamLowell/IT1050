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

        public string GetDogName()
        {
            this.Name = "";
            this.Name += "What is the dog's name? ";
            this.Name += Console.ReadLine();
            Console.WriteLine(this.Name);
            return GetDogName();
        }


    }
}
