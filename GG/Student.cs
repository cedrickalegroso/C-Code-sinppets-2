using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Alegroso_Finals
{
    class Student
    {
        /* General Stuffs */
        public int debugmode = 0; /* set this to 1 to get more data ;) */
        public double _total { get; set; }

        public double _Mideterm { get; set; }

        public double _Finals { get; set; }

        public double _Attendance { get; set; }

        public string _Name { get; set; }

        /*Lab stuuffs */
        public double _Laboratory1 { get; set; }

        public double _Laboratory2 { get; set; }

        public double _Laboratory3 { get; set; }

        public double _LabTotal { get; set; }


        /*Assinghment stuuffs */
        public double _Assignment1 { get; set; }

        public double _Assignment2 { get; set; }

        public double _Assignment3 { get; set; }

        public double _HWTotal { get; set; }




        /*
         * The function to call when we need something from the user to input
         */

        public void inputScores()
        {
         
            Console.WriteLine("\nEnter Student Information \n");
             Console.Write("Name : ");
            _Name = Console.ReadLine();

            Console.WriteLine("Laboratory exercises scores \n");

            Console.Write("Laboratory 1 (30pts): ");
            _Laboratory1 = int.Parse(Console.ReadLine());

            Console.Write("Laboratory 2 (30pts): ");
            _Laboratory2 = int.Parse(Console.ReadLine());

            Console.Write("Laboratory 3 (20pts): ");
            _Laboratory3 = int.Parse(Console.ReadLine());


            Console.WriteLine("\nAssignments scores \n");

            Console.Write("Assignment 1 (50pts): ");
            _Assignment1 = int.Parse(Console.ReadLine());

            Console.Write("Assignment 2 (50pts): ");
            _Assignment2 = int.Parse(Console.ReadLine());

            Console.Write("Assignment 3 (50pts): ");
            _Assignment3 = int.Parse(Console.ReadLine());


            Console.WriteLine("\nMidterm Examination Score \n");

            Console.Write("Midterm Examination score (100pts): ");
            _Mideterm = int.Parse(Console.ReadLine());


            Console.WriteLine("\nFinal Examination Score \n");

            Console.Write("Final Examination score (100pts): ");
            _Finals = int.Parse(Console.ReadLine());


            Console.WriteLine("\nAttendance \n");

            Console.Write("Attendance (30): ");
            _Attendance = int.Parse(Console.ReadLine());
        }


        /*
        * The function to call when we need something to be solved!
        */

        public void solver()
        {
            /*
             * For the Lab and HW I first Added them and given my own max score because it wasnt given
             * then i divided them with max score convert to percentage and multiply it by their weights
             * based on the Word Document.
             * 
             */

            _LabTotal = (((_Laboratory1 + _Laboratory2 + _Laboratory3) / 80 * 100) * .25);

            _HWTotal = (((_Assignment1 + _Assignment2 + _Assignment3) / 150 * 100) * .10);

            _total = _LabTotal + _HWTotal + ((_Mideterm / 100 * 100) * .25) + ((_Finals / 100 * 100) * .35) + (((_Attendance + 70) / 100 * 100) * .05);
        }

        /*
        * The dev tool if you enable debugmode this will be added in the output just some extra good for double checking stuffs :)
        */

        public void devtool()
        {
            Console.WriteLine("DEBUG ======================================================================");

            Console.WriteLine("Name: " + _Name);

            Console.WriteLine("lab: " + ((_Laboratory1 + _Laboratory2 + _Laboratory3) / 80 * 100) * .25) ;

            Console.WriteLine("HW: " + ((_Assignment1 + _Assignment2 + _Assignment3) / 150 * 100) * .10);

            Console.WriteLine("MID: " + ((_Mideterm / 100 * 100) * .25));

            Console.WriteLine("Finals: " + ((_Finals / 100 * 100) * .35));

            Console.WriteLine("Atte: " + (((_Attendance + 70) / 100 * 100) * .05));

            Console.WriteLine("============================================================================");
        }


        /*
        * The function to call if we want to check if any of the student passed or failed
        */

        public void ispassed()
        {
          
            Console.Write("Student " + _Name);
            
            if (Math.Truncate(_total) >= 60 ) // 60 is the passing mark!
            {
                Console.WriteLine(" PASSED");
            } else
            {
                Console.WriteLine(" FAILED");
            }

        }

        /*
        * The function to call if we want to convert the percentage to the used grading system
        */

        public void gradeEquiv()
        {
            // I used Math.Truncate because sometimes the output of _total is decimal so this is the
            // best way i found to convert the _total to a whole number first since we are just comparing
            // it with another whole number 

            solver(); // Calls the Solver first so we have a _total
            Console.Write("Student " + _Name + " got ");
            Console.Write(Math.Truncate(_total) + "% that is equivalent to ");

            if (Math.Truncate(_total) >= 0 && Math.Truncate(_total) <= 49 )
            {
                Console.WriteLine("5");
            }else if (Math.Truncate(_total) >= 50 && Math.Truncate(_total) <= 55)
            {
                Console.WriteLine("3");
            }else if (Math.Truncate(_total) >= 56 && Math.Truncate(_total) <= 61)
            {
                Console.WriteLine("2.75");
            }
            else if (Math.Truncate(_total) >= 62 && Math.Truncate(_total) <= 67)
            {
                Console.WriteLine("2.5");
            }
            else if (Math.Truncate(_total) >= 68 && Math.Truncate(_total) <= 73)
            {
                Console.WriteLine("2.25");
            }
            else if (Math.Truncate(_total) >= 74 && Math.Truncate(_total) <= 79)
            {
                Console.WriteLine("2");
            }
            else if (Math.Truncate(_total) >= 80 && Math.Truncate(_total) <= 85)
            {
                Console.WriteLine("1.75");
            }
            else if (Math.Truncate(_total) >= 86 && Math.Truncate(_total) <= 90)
            {
                Console.WriteLine("1.5");
            }
            else if (Math.Truncate(_total) >= 91 && Math.Truncate(_total) <= 95)
            {
                Console.WriteLine("1.25");
            }
            else if (Math.Truncate(_total) >= 96 && Math.Truncate(_total) <= 100)
            {
                Console.WriteLine("1");
            }

            if (debugmode == 1)
            {
                devtool(); //Calls the devtool
            }



        }




    }


    // More random debugging stuffs? I only used this when building the foundation of this source code. Not being used ATM but may help in debugging

    class Student1 : Student // Student 1 is a child of Student Parent
    {
      
        public void output()
        {
            Console.WriteLine("Student 1");
            Console.WriteLine("Name: " + _Name);
            Console.WriteLine("\nLaboratory 1: " + _Laboratory1);
            Console.WriteLine("Laboratory 2: " + _Laboratory2);
            Console.WriteLine("Laboratory 3: " + _Laboratory3);
            Console.WriteLine("Assignment 1: " + _Assignment1);
            Console.WriteLine("Assignment 2: " + _Assignment2);
            Console.WriteLine("Assignment 3: " + _Assignment3);
            Console.WriteLine("Midterm: " + _Mideterm );
            Console.WriteLine("Finals: " + _Finals);
            Console.WriteLine("Attendance: " + _Attendance);
            Console.WriteLine("Total: " + _total );

            if (debugmode == 1)
            {
                devtool();
            }
        }
    }

    class Student2 : Student // Student 2 is a child of Student Parent
    {
        
        public void output()
        {
            Console.WriteLine("Student 2");
            Console.WriteLine("Name: " + _Name);
            Console.WriteLine("Laboratory 1: " + _Laboratory1);
            Console.WriteLine("Laboratory 2: " + _Laboratory2);
            Console.WriteLine("Laboratory 3: " + _Laboratory3);
            Console.WriteLine("Assignment 1: " + _Assignment1);
            Console.WriteLine("Assignment 2: " + _Assignment2);
            Console.WriteLine("Assignment 3: " + _Assignment3);
            Console.WriteLine("Midterm: " + _Mideterm);
            Console.WriteLine("Finals: " + _Finals);
            Console.WriteLine("Attendance: " + _Attendance);
            Console.WriteLine("");


            if (debugmode == 1)
            {
                devtool();
            }

        }
    }

    class Student3 : Student // Student 3 is a child of Student Parent
    {
        
        public void output()
        {
            Console.WriteLine("Student 3");
            Console.WriteLine("Name: " + _Name);
            Console.WriteLine("Laboratory 1: " + _Laboratory1);
            Console.WriteLine("Laboratory 2: " + _Laboratory2);
            Console.WriteLine("Laboratory 3: " + _Laboratory3);
            Console.WriteLine("Assignment 1: " + _Assignment1);
            Console.WriteLine("Assignment 2: " + _Assignment2);
            Console.WriteLine("Assignment 3: " + _Assignment3);
            Console.WriteLine("Midterm: " + _Mideterm);
            Console.WriteLine("Finals: " + _Finals);
            Console.WriteLine("Attendance: " + _Attendance);
            Console.WriteLine("");


            if (debugmode == 1)
            {
                devtool();
            }

        }
    }

}
