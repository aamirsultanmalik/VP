
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Please Enter Input");
            input = Console.ReadLine();
            char[] arr = input.ToCharArray();
            int sum = 0, carry = 0;
            int spaceIdex = Array.IndexOf(arr, ' ');
            string lhs = "", rhs = "";
            for (int i = 0; i < spaceIdex; i++)
            {
                lhs += arr[i].ToString();
            }
            for (int i = spaceIdex+1; i < arr.Length; i++)
            {
                rhs += arr[i].ToString();
            }
            //char[,] td = new char[6, 2]{
            //{'A',char.Parse("1")},
            //{'B',char.Parse("1")},
            //{'C',char.Parse("1")},
            //{'D',char.Parse("1")},
            //{'E',char.Parse("1")},
            //{'F',char.Parse("1")},
            //};
            List<char> charList = new List<char>();
            charList.Add('A');
            charList.Add('B');
            charList.Add('C');
            charList.Add('D');
            charList.Add('E');
            charList.Add('F');
            List<int> numberList = new List<int>();
            numberList.Add(10);
            numberList.Add(11);
            numberList.Add(12);
            numberList.Add(13);
            numberList.Add(14);
            numberList.Add(15);
            char[] lhsArr = lhs.ToCharArray();
            char[] rhsArr = rhs.ToCharArray();
            int lrhs = rhsArr.Length, llhs = lhsArr.Length, lDiff = llhs - lrhs,indexCharList;
            for (int i = 0; i < rhsArr.Length; i++)
            {
                if (char.IsLetter(rhsArr[i]))
                {
                    indexCharList= charList.IndexOf(rhsArr[i]);
                    rhsArr[i] =(char) numberList.ElementAt<int>(indexCharList);
                }
                if (char.IsLetter(lhsArr[i+lDiff]))
                {
                    indexCharList = charList.IndexOf(lhsArr[i]);
                    lhsArr[i] = (char)numberList.ElementAt<int>(indexCharList);
                }
                //if (i == rhsArr.Length - 1)
                //{
                //    continue;
                //}
                //else
                {
                    sum = lhsArr[i+lDiff] + rhsArr[i];
                    if (sum>15)
                    {
                        carry++;
                    }
                }
            }
            Console.WriteLine(carry);
        }
    }
}
