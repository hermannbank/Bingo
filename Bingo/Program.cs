using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bingo player!");

            Random random = new Random();
            var dic = new Dictionary<int, int>();
            int randomNumber = -1;
            while (true)
            {
                var text = Console.ReadLine();

                if (text == "")
                {
                    randomNumber = random.Next(1, 91);
                    while ( dic.ContainsKey(randomNumber))
                    {
                        randomNumber = random.Next(1, 90);
                    }

                    if (randomNumber == 90)
                    {
                        Console.WriteLine("Gamle Ole");
                    }
                    
                    dic.Add(randomNumber, dic.Count + 1);
                    
                    
                    Console.WriteLine($"Number: {randomNumber}");
                }

                if (dic.Count == 91)
                {
                    Console.WriteLine($"All numbers have been found, number of passes {dic.Values.Last()}");
                }

                if (text == "q")
                {
                    return;
                }

                if (text == "l")
                {
                    Console.WriteLine($"Numbers so far:");
                    foreach (var tal in dic.Keys.OrderBy(x=>x).ToList())
                    {
                        Console.WriteLine(tal);
                    }
                }

            }
        }
    }
}
