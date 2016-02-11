using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string go = "yes";
            do
            {
                Console.WriteLine("Please enter your string...");

                string s = Console.ReadLine();

                char[] arr = s.ToCharArray(0, s.Length);

                Console.Write(arr);
                Console.WriteLine();
                Console.WriteLine("Enter 'yes' to continue...");
                
                go = Console.ReadLine();
            }
            while (go == "yes");
        }
    }
}
