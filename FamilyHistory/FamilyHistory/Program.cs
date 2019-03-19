using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyHistory
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Flossie = new Person("Florence Rockwell", "F");
            Flossie.BirthDay = "October 27, 1918";
            
            Person Anna = new Person("Anna Taber Edgerton", "A");
            Anna.BirthDay = "October 30, 1876";
            Anna.DeathDay = "November 17, 1957";
            
            Person Walter = new Person("Walter James Edgerton", "W");
            Walter.BirthDay = "January 11, 1871";
            Walter.DeathDay = "September 24, 1908";
            
            Person Beth = new Person("Elizabeth Edgerton", "B");
            Beth.BirthDay = "June 10, 1908";
            
            Person Louis = new Person("Louis Rockwell", "L");
            Louis.BirthDay = "January 28, 1914";
            
            Person Mamie = new Person("Mabel Edgerton", "M");
            Mamie.BirthDay = "May 1, 1912";
            
            Person Sam = new Person("C. Franklin Rockwell", "S");
            
            Anna.NameInitailBirthday();
            Walter.NameInitailBirthday();
            Beth.NameInitailBirthday();
            Mamie.NameInitailBirthday();
            Louis.NameInitailBirthday();
            Flossie.NameInitailBirthday();

            System.Console.ReadKey();
       
        }
    }
}
