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

        static void Main_Circle(string[] args)
        {
        decimal Pi = 3.1415926535M;
            
        Console.WriteLine("Hello! Please enter the radius of your circle");
        string sRadius = Console.ReadLine();
        decimal dRadius;
        try
        {
        dRadius = decimal.Parse(sRadius);
        }
        catch(Exception)
        {
            Console.WriteLine("Oops, Error with entered value :/");
            return;
        }
        decimal dCircumference = (Pi * (2*dRadius));
        decimal dArea = (Pi * (dRadius*dRadius));
        Console.WriteLine("Cirumference: " + dCircumference);
        Console.WriteLine("Area: " + dArea);
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



        static void Main_ForAngles(string[] args)
        {
            decimal firstAngleInt = Fun1("First angle pleasey");
            decimal secondAngleInt = Fun1("Second angle pleasey");
            
            if((firstAngleInt + secondAngleInt) >= 180)
            {
                Console.WriteLine("Hmm... Angle 1 + Angle 2 is too big...");
                return;
            }    
            decimal thirdAngle = 180-(firstAngleInt + secondAngleInt);

            string thirdAngleString = thirdAngle.ToString();
            
            Console.WriteLine(thirdAngleString);


        }
    }
}