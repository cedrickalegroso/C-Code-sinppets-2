using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Alegroso_LacorteQ2
{
    class Program
    {

        static void Main(string[] args)
        {

            factorial factor = new factorial();
            Console.Write("Enter the Number: ");
            factor.number = double.Parse(Console.ReadLine());
            Console.WriteLine("Factorial of Given Number is: " + factor.answer());

        }
    }
}
