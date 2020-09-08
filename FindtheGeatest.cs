using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alegroso_Activity1
{
    class Program
    {
        static void Main(string[] args)
        {
            float sum, diff, product, qoutient, highest, lowest;
            int num1, num2, counter = 0;
            // array so we can loop later YAHAY!
            List<float> arrayopr = new List<float>();

            Console.Write("Input first Number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Input Second Number: ");
            num2 = int.Parse(Console.ReadLine());

            // solve the results every opetaion and add them to a array so we can loop thorugh the 
            // answer later
            sum = num1 + num2;
            arrayopr.Add(sum);
            diff = num1 - num2;
            arrayopr.Add(diff);
            product = num1 * num2;
            arrayopr.Add(product);
            qoutient = num1 / num2;
            arrayopr.Add(qoutient);

            //nothing just initialize 
            highest = 0;
            lowest = 0;

            //starting the loop
            while (counter < 4 )
            {                
                if (arrayopr[counter] > highest) // if the current highest greater than the current array index
                { 
                    if (counter == 0)
                    {
                        highest = arrayopr[counter];
                        lowest = arrayopr[counter];
                    } else
                    {           
                        highest = arrayopr[counter];                
                    }
                } else if (lowest > arrayopr[counter])
                {
                    lowest = arrayopr[counter];
                }           
                counter++; // add 1 every loop                 
            }

            Console.WriteLine(" Sum: {0} \n Difference: {1} \n Product: {2} \n Qoutient: {3} \n Highest: {4} \n Lowest: {5} ", sum, diff, product , qoutient, highest, lowest);

    
        }
    }
}
