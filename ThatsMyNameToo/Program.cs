using System;

namespace ThatsMyNameToo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("whats your name");
            string name = Console.ReadLine().ToLower();

            bool isJen = name.Equals("jen");
            bool isSarah = name.Equals("sarah");

            switch (name)
            {
                case "jen":
                    Console.WriteLine("that's mine");
                    break;

                case "sarah":
                    Console.WriteLine("thats my daughters name");
                    break;

                default:
                    Console.WriteLine("Hi");
                    break;
            }
            }
        }
    }

