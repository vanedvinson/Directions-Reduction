using System;
using System.Collections.Generic;
using System.Linq;

namespace Directions_Reduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[] { "NORTH", "SOUTH", "WEST", "EAST", "SOUTH", "EAST" };
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
                List<string> two = arr.ToList();

                for (int i = 0; i < one.Count(); i++)
                {
                    switch (one[i])
                    {
                        case "NORTH":
                            try
                            {
                                if (one[i + 1] == "SOUTH")
                                {
                                    two[i + 1] = "";
                                    two[i] = "";
                                }
                            }
                            catch{}
                            break;
                        case "SOUTH":
                            try
                            {
                                if (one[i + 1] == "NORTH")
                                {
                                    two[i + 1] = "";
                                    two[i] = "";
                                }
                            }
                            catch{}
                            break;
                        case "WEST":
                            try
                            {
                                if (one[i + 1] == "EAST")
                                {
                                    two[i + 1] = "";
                                    two[i] = "";
                                }
                            }
                            catch{}
                            break;
                        case "EAST":
                            try
                            {
                                if (one[i + 1] == "WEST")
                                {
                                    two[i + 1] = "";
                                    two[i] = "";
                                }
                            }
                            catch{}
                            break;
                    }
                }
               
                
                two.RemoveAll(x => x == "");
                if (one.Count() == two.Count()) return two.ToArray();
                else one = two;
                
                return dirReduc(two.ToArray());
            }
        }
    }
}
