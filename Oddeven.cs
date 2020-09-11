using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alegroso_Activity3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, odd = 0, even = 0, totaleven =0, totalodd = 0, backupeven, backupodd;

            List<float> evenarr = new List<float>();
            List<float> oddarr = new List<float>();


            Console.Write("Enter the min:" );
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the max:");
            n2 = int.Parse(Console.ReadLine());

            while(n1 <= n2)
            {
               
                if (n1 % 2 == 0 )
                {
                    
                    evenarr.Add(n1);  // add the number to array
                    backupeven = n1; // back up so we can go back to the current n1?
                    totaleven = n1 + totaleven; // add it on the current value 
                    even++;  // add even 
                    n1 = backupeven; // go back to the saved state :) 
                } else
                {
                   
                    oddarr.Add(n1); // add the number to array
                    backupodd = n1; // back up so we can go back to the current n1?
                    totalodd = n1 + totalodd; // add it on the current value 
                    odd++;       // add odd      
                    backupodd = n1;  // go back to the saved state :) 
                }
                // Console.WriteLine(n1);
                ++n1;
            }

       
            /// print the sum of all even

            Console.Write("The sum of all EVEN numbers ");

           
            for (int eveni = 0; eveni < evenarr.Count; eveni++)
            {
                Console.Write(" " + evenarr[eveni]);
            }

            Console.Write(" is {0} ", totaleven);

            

            Console.WriteLine("");

            /// print the sum of all odds

            Console.Write("The sum of all ODD numbers ");

            for (int oddi = 0; oddi < oddarr.Count; oddi++)
            {
                Console.Write(" " + oddarr[oddi]);
            }

            Console.Write(" is {0} ", totalodd);


            Console.WriteLine("");


            if (totalodd > totaleven)
            {
                Console.WriteLine("Higher  Number: ODD");
                Console.WriteLine("Lower   Number: Even");
            } else
            {
                Console.WriteLine("Higher  Number: Even");
                Console.WriteLine("Lower   Number: ODD");
            }








        }
    }
}
