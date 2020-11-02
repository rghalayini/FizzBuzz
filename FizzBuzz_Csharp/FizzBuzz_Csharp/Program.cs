using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert how many integers you want in your FizzBuzz program:");
            int n = Convert.ToInt32(Console.ReadLine());

            string output = "";

            for (int i = 1; i < n+1; i++)
            {
                if (i % 3 == 0 && i% 4 == 0)
                    { 
                        output += "FizzBuzz "; 
                    }
                else if (i % 3 == 0)
                    { 
                        output += "Fizz "; 
                    }
                else if (i % 4 == 0)
                    { 
                        output += "Buzz "; 
                    }
                else
                    {
                        output += i+" ";  
                    }               
            }
            Console.WriteLine();
            Console.WriteLine("Your FizzBuzz is:");
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }  
}

