using System;
using System.Collections.Generic;

namespace ExampleListForeach
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var rand = new Random();
            List<object> id = new List<object>();
            for (var i = 1; i < 6; i++)
                id.Add(rand.Next(0,1000).ToString().GetHashCode());

            Console.WriteLine(@"Print method.");
            id.ForEach(Print);
            Console.WriteLine();

            Console.WriteLine(@"Anonymous method.");
            id.ForEach(item => 
            {
                Console.WriteLine(@"id.GetHashCode() == " + Convert.ToString(item.GetHashCode()));
            });
            Console.WriteLine();

            Console.WriteLine(@"Anonymous method.");
            id.ForEach(delegate (object item)
            {
                Console.WriteLine(@"id.GetHashCode() == " + Convert.ToString(item.GetHashCode()));
            });
            Console.WriteLine();

            Console.ReadLine();
        }

        private static void Print(object item)
        {
            Console.WriteLine(@"id.GetHashCode() == " + Convert.ToString(item.GetHashCode()));
        }
    }
}
