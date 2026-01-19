using System;
namespace TopBrainsPractice
{
    public class FeetToCm
    {
        public double FeetConversion(int feet)
        {
            double conversionValue = 30.48;
            double result = conversionValue * feet;
            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }
    }
    public class ConversionMain 
    { 
        public static void Main(string[] args)
        {
            FeetToCm fe = new FeetToCm();
            Console.Write("Enter the feet to convert to cm: ");
            int input = Int32.Parse(Console.ReadLine());
            if (input > 0 && input < 100000)
            {
                double cm=fe.FeetConversion(input);
                Console.WriteLine($"The Converted Value from {input} feet to cm is {cm} cm");
            }

            else
            {
                Console.WriteLine("Invalid input(feet).");
            }
        }
    }
}
