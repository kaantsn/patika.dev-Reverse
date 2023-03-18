using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen bir yazı yazın");
            string output = System.Console.ReadLine();
            string reversee = "";

            for (int i = output.Length - 1; i >= 0; i--)
            {
                reversee += output.Substring(i, 1);
            }

            System.Console.WriteLine(reversee);

            Console.ReadLine();
        }
          
    }
}
