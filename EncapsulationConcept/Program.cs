using System;

namespace EncapsulationConcept
{
    class Program
    {
          

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
