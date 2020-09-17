using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Alegroso_LacorteQ1
{
    class discount
    {
        private double Quantity;
        private int TransType;
        private double dis;

        public double quantity
        {
            get { return Quantity; } // getter 
            set { Quantity = value; } // setter
        }

        public int transtype
        {
            get { return TransType; } 
            set { TransType = value; }
        }


        public double output()
        {

          
            logic(); // calls the discount logic
            return dis; // returns the discounted value

        }

        public void logic()
        {
            if (transtype == 1) // if the transaction type was cash 
            {
                if (quantity <= 10)
                {
                    dis = 5;
                }
                else if (quantity > 10 && quantity <= 50)
                {
                    dis = 10;
                }
                else if (quantity > 50 && quantity <= 100)
                {
                    dis = 15;
                }
            } else if (transtype == 2) // if the transaction type was credit 
            {
                if (quantity <= 25)
                {
                    dis = 3;
                }
                else if (quantity > 25 && quantity <= 75)
                {
                    dis = 7;
                }
                else if (quantity > 75 && quantity <= 100)
                {
                    dis = 10;
                }
            }
           
        }
    }
}
