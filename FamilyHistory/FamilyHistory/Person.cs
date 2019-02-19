using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyHistory
{
    class Person
    {
        public string Name;
        public string BirthDay;
        public string letterInitial;
        public string DeathDay;

        public void NameInitailBirthday()
        {
            System.Console.WriteLine(this.Name);
            System.Console.WriteLine("Initail: " + this.letterInitial);
            System.Console.WriteLine(this.BirthDay);
            System.Console.WriteLine(" ");
          
            
        }
    }
}
