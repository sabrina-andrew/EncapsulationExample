using System;

namespace EncapsulationConcept
{
    class Program
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

        static void Main(string[] args)
        {
            double input1, input2;

            Console.WriteLine("Enter 1st number = ");
            input1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter 2nd number = ");
            input2 = Convert.ToDouble(Console.ReadLine());

            Calculator obj1 = new Calculator(input1, input2);

            obj1.DisplayResult();
        }
    }
}
