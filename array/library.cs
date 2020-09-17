using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Alegroso_LacorteQ3
{
    class library
    {
        private int Number;
        private int ArrayInt;
        private int counter = 1 ;
        private List<int> arrayList = new List<int>();

        public int number  // the first int being asked to the user
        {
            get { return Number; } // getter
            set { Number = value; } // setter
        }

        public int arrayint // the int asked in the  while loop
        {
            get { return ArrayInt; } // getter
            set { ArrayInt = value; } // setter
        }

        /* OUTPUT METHOD ===========================================================================
         * accepts parameter on what to output example usage output(param here) accepted params are   
         * [1] is to get the index and digits of the given int
         * [2] the min max of the aarray
         * [3] outpts the while loop that will ask for the integer 
        */

        public int output(int i) 
        {
            if (i == 1) 
            {
                return number.ToString().Length; //sets the significant digit of the given integer
            } else if ( i == 2)
            {
                /* WHY LIST? ===========================================================================
                 * We used list because it was easy to use than array since we dont need anything really.
                 * just group some int then call it later to what is the highest and lowest 
                 * So we opted to use list and then after everything is done we can just convert this 
                 * to an array and use the Min() Max() function to output which is greatest and lowest
                 */

                int[] array = arrayList.ToArray(); 
                Console.WriteLine("The lowest element in the array is {0} and the highest element is {1}", array.Min(), array.Max()); // prints the min max 
            } else if ( i == 3)
            {

                /* THE WHILE LOOP ========================================================================
                *  First we have a counter so we can keep track of the index 
                *  Then it would ask the user for the value for the list
                *  after adding it to a list it would incerment the counter so we can move on the next index
                *  when condition satisfy the while loop it would break and will call the output(2)
                */

                while (counter <= output(1))
                {
                    Console.Write("Please enter the " + counter + " element of the array: ");
                    arrayList.Add(arrayint = int.Parse(Console.ReadLine()));
                    counter++;
                }
                output(2);
            }
            return 404;  //if above doesnt work we can have a fallback of nothing  
        }

       
    }
}
