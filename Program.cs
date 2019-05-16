using System;

namespace ConsoleApp1
{


    class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            Console.WriteLine("Enter the initial capital : ");
            decimal initialCapital = decimal.Parse(Console.ReadLine());


            Console.WriteLine("Enter the interest Rate : ");
            decimal interest = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the years : ");
            int years = int.Parse(Console.ReadLine());
            //PROCESSING
            decimal finalCapital = CapitalCalculation(initialCapital, interest, years);

            //OUTPUT
            Console.WriteLine("The final capital is {0} with interest Rate {1}", finalCapital, interest);


            //int x = 2147483647;
            //Console.WriteLine("x={0}", x);
            //Console.WriteLine("x+1={0}", x+1);
            //Console.WriteLine("x+2={0}", x+2);

            Console.ReadLine();
        }
        /*
        *Calculates teh capital
        *given the initial capital interest
        *rate and tthe years
        **/
        static decimal CapitalCalculation(decimal initialCapital, decimal interest, int years)
        {

            double finalCapitalDouble = Math.Pow((1 + (double)interest), years) * (double)initialCapital;
            decimal finalCapital = (decimal)finalCapitalDouble;
            //Accordng to capital control rule  R2124
            //  Date of update 2019
            // Author dpi
            if (finalCapital > 2000)
            {
                finalCapital = 2000;
            }


            return finalCapital;
        }

    }
}
