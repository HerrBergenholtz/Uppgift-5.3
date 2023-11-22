using System;

namespace Uppgift_5._3
{
    class Program
    {
        public static void Main() 
        {
            try
            {
                int[] talArray = new int[3];
                Console.WriteLine("Skriv in tre tal på olika rader");
                for (int i = 0; i < talArray.Length; i++)
                {
                    talArray[i] = int.Parse(Console.ReadLine());
                }
                int summa = 0;
                foreach (int i in talArray)
                {
                    summa += i;
                }
                Console.WriteLine($"Summan av alla tal är {summa}");
                Console.ReadKey();

            }
            catch
            {
                Console.WriteLine("Du gav inte rätt input, försök igen");
                Main();
            }
        }
    }
}