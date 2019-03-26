using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyHistory
{
    class Person
    {
        private string Name;
        private string BirthDay;
        private string letterInitial;
        private string DeathDay;

        public Person(string name, string letter)
        {
            this.Name = name;
            this.letterInitial = letter;
        }

        public void NameInitailBirthday()
        {
            System.Console.WriteLine(this.Name);
            System.Console.WriteLine("Initail: " + this.letterInitial);
            System.Console.WriteLine(this.BirthDay);
            System.Console.WriteLine(" ");
          
            
        }
        public void setBirthDay(string BirthDay)
        {
            this.BirthDay = BirthDay;
        }
        public void setDeathDay(string DeathDay)
        {
            this.DeathDay = DeathDay;
        }
    }
}
