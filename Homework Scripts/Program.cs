using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Types of Variables (Most Common)
            /*There are several types of Variables(var), but the most common are:
             * int,float,double,char,bool,string. I will discribe each.*/

            //This code, using var int, will write a line with the number 15. int variables can only be whole numbers.
            int x = 15;
            Console.WriteLine(x);
            //Output = 15

            //This code, using var double, will output 15.5, which is a rational number.
            double y = 15.5;
            Console.WriteLine(y);
            //Output = 15.5

            //This code, using char, will output a character, rather than a number. char, oposed to strings, use '' single quotes, rather than "" double.
            char z = 'K';
            Console.WriteLine(z);
            //Output = K

            //This code, using bool, is simply a true or false Variable.
            bool nameKnight = true;
            Console.WriteLine(nameKnight);
            //Output = true

            /*This code, using string, simply is a writen phrase given to the Variable. 
            Words(and numbers) in a string, can be literally anything, as long as they are inclosed with "" double quotes.*/
            string thisClass = "Scripting Is Awesome!";
            Console.WriteLine(thisClass);
            //Output = Scripting Is Awesome!



        }
    }
}
