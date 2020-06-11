using System;

namespace LacoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Bob", "Alex", "Paula", "Adriano" };

            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
