using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationConcept
{
    class Calculator
    {   //Encapsulated 
        private double value1;
        private double value2;


        //Constructor (Same name as class)
        public Calculator(double input1, double input2)
        {
            value1 = input1;
            value2 = input2;
        }
        public double Multiplication()
        {
            return value1 * value2;
        }

        public void DisplayResult()
        {
            Console.WriteLine("Multiplication result " + Multiplication());
        }

    }
}
