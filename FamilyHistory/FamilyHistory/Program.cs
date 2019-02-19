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
            Person Flossie = new Person();
            Flossie.Name = "Florence Rockwell";
            Flossie.BirthDay = "October 27, 1918";
            Flossie.letterInitial = "F";

            Person Anna = new Person();
            Anna.Name = "Anna Taber Edgerton";
            Anna.BirthDay = "October 30, 1876";
            Anna.DeathDay = "November 17, 1957";
            Anna.letterInitial = "A";

            Person Walter = new Person();
            Walter.Name = "Walter James Edgerton";
            Walter.BirthDay = "January 11, 1871";
            Walter.DeathDay = "September 24, 1908";
            Walter.letterInitial = "W";

            Person Beth = new Person();
            Beth.Name = "Elizabeth Edgerton Rockwell";
            Beth.BirthDay = "June 10, 1908";
            Beth.letterInitial = "B";

            Person Louis = new Person();
            Louis.Name = "Louis Rockwell";
            Louis.BirthDay = "January 28, 1914";
            Louis.letterInitial = "L";

            Person Mamie = new Person();
            Mamie.Name = "Mabel Edgerton";
            Mamie.BirthDay = "May 1, 1912";
            Mamie.letterInitial = "M";

            Person Sam = new Person();
            Sam.Name = "C. Franklin Rockwell";
            Sam.letterInitial = "S";

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
