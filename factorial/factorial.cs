using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Alegroso_LacorteQ2
{
    class factorial
    {

        private double Number; 
        private double Fact = 1; // predefined value for factorial
        public double number
        {
            get { return Number; } // getter
            set { Number = value; } // sets the value
        }

        public double answer()
        {
            solver(); // will call the solver method 
            return Fact; // will return the output to the console
        }

        private void solver()
        {
            while (number > 1)
            {
                Fact = Fact * number;
                number = number - 1;
            }
        }
    }
}
