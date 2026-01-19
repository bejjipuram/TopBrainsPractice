using System;

namespace TopBrainsPractice
{
    public class SwapNumbers
    {
        // Method 1: Swap using ref (no temp variable)
        public void SwapUsingRef(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        // Method 2: Swap using out (no temp variable)
        public void SwapUsingOut(int a, int b, out int x, out int y)
        {
            x = a + b;
            y = x - b;
            x = x - y;
        }
    }

    public class SwapMain
    {
        public static void Main(string[] args)
        {
            SwapNumbers swap = new SwapNumbers();

            Console.Write("Enter first number: ");
            int n1 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int n2 = Int32.Parse(Console.ReadLine());

            // Swap using ref
            Console.WriteLine("\n--- Swap using ref ---");
            swap.SwapUsingRef(ref n1, ref n2);
            Console.WriteLine($"After swap: n1 = {n1}, n2 = {n2}");

            // Swap using out
            Console.WriteLine("\n--- Swap using out ---");
            swap.SwapUsingOut(n1, n2, out int x, out int y);
            Console.WriteLine($"After swap: x = {x}, y = {y}");
        }
    }
}
