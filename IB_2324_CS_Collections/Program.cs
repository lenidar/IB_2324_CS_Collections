using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB_2324_CS_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] numbers = new int[rnd.Next(5, 10000)];

            numbers[0] = rnd.Next(5, 10000); // assignment of a value to an index

            for(int x = 1; x < numbers.Length; x++)
            {
                numbers[x] = numbers[x - 1] + 1; // assignment of a value based on another index
            }

            for(int x = 0; x < numbers.Length; x++)
            {
                Console.WriteLine(numbers[x]);
            }

            Console.ReadLine();
        }
    }
}
