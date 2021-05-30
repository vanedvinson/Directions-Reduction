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

                int bla = one.Where(x => x.Equals("NORTH")).Count() - one.Where(x => x.Equals("SOUTH")).Count();
                int bla2 = one.Where(x => x.Equals("WEST")).Count() - one.Where(x => x.Equals("EAST")).Count();

                if (bla > 0) for (int i = 0; i < bla; i++) two.Add("NORTH");
                else if (bla < 0) for (int i = 0; i < Math.Abs(bla); i++) two.Add("SOUTH");

                if (bla2 > 0) for (int i = 0; i < bla2; i++) two.Add("WEST");
                else if (bla2 < 0) for (int i = 0; i < Math.Abs(bla2); i++) two.Add("EAST");



                return two.ToArray();
            }
        }
    }
}
