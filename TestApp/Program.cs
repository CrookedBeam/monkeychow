using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, number please!");
            string sNumber = Console.ReadLine();
            int iNumber;
            try
            {
                iNumber = int.Parse(sNumber);
            }
            catch(Exception)
            {
                Console.WriteLine("Oh... maybe I should've asked for an Integer instead?");
                return;
            }

            int i = 1;
            while(i<11)
            {
                Console.WriteLine(iNumber*i);
                i++;
            }
        

        }
        
        static decimal Fun1(string args)
        {
            Console.WriteLine(args);
            string Angle = Console.ReadLine();
            decimal AngleInt;
            try
            {
                AngleInt = decimal.Parse(Angle);
            }
            catch(Exception)
            {
                Console.WriteLine("Entered angle is not a number.");
                return Fun1(args);
            }

            if (AngleInt < 0)
            {
                Console.WriteLine("Uh Oh. Angles cannot be negative!");
                return Fun1(args);
            }    
        return AngleInt;
        }



    }
}