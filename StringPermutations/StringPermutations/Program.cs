using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            Console.WriteLine("Please Enter String");
            inputString = Console.ReadLine();
            powerSet(inputString);
        }
        public static void powerSet(string input)
        {
            char[] arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != '{' && arr[i] != '}' && arr[i] != ',')
                {
                    for (int j = i; j < arr.Length; j++)
                    {
                        if (arr[j] != '{' && arr[j] != '}' && arr[j] != ',')
                        {
                            Console.Write(arr[i] + "," + arr[j]);
                        }
                    }
                }
            }
        }
    }
}
