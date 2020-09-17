using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Alegroso_LacorteQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            discount disc = new discount();

            Console.Write("Enter transaction type [1] = Cash | [2] = Credit: ");
            disc.transtype = int.Parse(Console.ReadLine());
            Console.Write("Enter quantity: ");
            disc.quantity = double.Parse(Console.ReadLine());

            Console.WriteLine("Discount " + disc.output() +"%");
        }
    }
}
