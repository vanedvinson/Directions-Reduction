using System;
using System.Collections.Generic;
using System.Linq;

namespace Directions_Reduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST", "SOUTH" };
            string[] c = new string[] { "NORTH", "WEST", "SOUTH", "EAST", "NORTH" };
            string[] d = new string[] { "NORTH", "WEST", "SOUTH", "EAST", "WEST", "WEST" };

            Console.WriteLine(dirReduc(a));
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(dirReduc(b));
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(dirReduc(c));
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(dirReduc(d));

            string[] dirReduc(String[] arr)
            {
                List<string> one = arr.ToList();
                List<string> two = new List<string>();

                for (int i = 0; i < one.Count(); i++)
                {
                    if (one[i] == "NORTH" && one[i + 1] == "SOUTH")
                    {
                        one.Remove(one[i + 1]);
                        one.Remove(one[i]);
                    }
                }

                for (int i = 0; i < one.Count(); i++) Console.WriteLine(one[i]);

                return two.ToArray();
            }
        }
    }
}
