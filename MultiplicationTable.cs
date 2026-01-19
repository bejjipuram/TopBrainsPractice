using System;
using System.Collections.Generic;
using System.Text;

namespace TopBrainsPractice
{
    public class MultiplicationTable
    {
        public int[] GetRow(int n, int upto)
        {
            int[] row = new int[upto];
            for(int i = 1; i <= upto; i++)
            {
                row[i - 1] = n * i;
            }
            return row;
        }
    }
    public class TableMain
    {
        public static void Main(string[] args)
        {
            MultiplicationTable table = new MultiplicationTable();
            Console.Write("Enter the number(n): ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the limit(upto): ");
            int upto = Int32.Parse(Console.ReadLine());
            if(upto>=0 && upto <= 100000)
            {
                int[] result = table.GetRow(n, upto);
                Console.Write($"Multiplication row for {n}: ");
                Console.Write("[ ");
                for (int i = 0; i < result.Length; i++)
                {

                    Console.Write(result[i]);
                    if (i < result.Length - 1)
                    {
                        Console.Write(", ");
                    }
                    
                }
                Console.Write(" ]");
            }
            else
            {
                Console.WriteLine("Invalid input (upto).");
            }
        }
    }
}
