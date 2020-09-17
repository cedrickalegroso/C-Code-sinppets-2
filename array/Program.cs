using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Alegroso_LacorteQ3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            library lib = new library(); //calls the class lib below are normal struffs no need comments hehez

            Console.WriteLine("Enter a number: ");
            lib.number = int.Parse(Console.ReadLine()); 

            Console.Write("\nNumber " + lib.number + "  has " + lib.output(1) + " digits. \n"  );
            Console.WriteLine("The array should have " + lib.output(1)  + " items. " );
            lib.output(3);
         

        }
    }
}
