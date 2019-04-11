using FizBuzzLib;
using System;

namespace FizBuzz
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int upper = 100;
            IFizBuzzCalculator fizbuzz = new FizBuzzCalculator();
            var results = fizbuzz.GetAllValues(upper);
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

    }
}
