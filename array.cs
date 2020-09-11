using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lastname_Activity3._2
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;
            List<float> arraynum = new List<float>();

            Console.Write("Enter min:");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter max:");
            num2 = int.Parse(Console.ReadLine());

            while (num1 <= num2)
            {
                //Console.Write(arraynum);
                arraynum.Add(num1);
                num1++;
            }

            Console.Write(" Array = [");

            for (int arrayi = 0; arrayi < arraynum.Count; arrayi++)
            {
                Console.Write(" " + arraynum[arrayi] + ",");
            }

            Console.Write(" ] ");

        }
    }
}
