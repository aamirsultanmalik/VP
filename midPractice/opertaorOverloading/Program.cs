using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opertaorOverloading
{
    class math
    {
        int x,y;
        public math(int _x,int _y )
        {
            x = _x;
            y = _y;
        }
        public static math operator+(math x,math y)
        {
            return new math(x.x + x.y, y.x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //math mt = new math(3, 2);
            //math mt1 = new math(3, 4);
            //math sum = mt + mt1;
            //string atr = "aamirawseae";
            //string str = "";
            ////bool found = false;
            //char[] arr = atr.ToCharArray();
            //char[] arr1 = new char[arr.Length];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i]=='a')
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        str += arr[i].ToString();
            //    }
            //}
            //Console.WriteLine(str);
            //char ch;
            //foreach (char item in atr)
            //{
            //    if (atr.LastIndexOf(item)==atr.IndexOf(item))
            //    {
            //        Console.WriteLine(item);
            //        break;
            //    }
            //}
            //Console.WriteLine(numberOf("aamir",'a'));

            //string str = "aqib";
            //string str1 = null;
            //char[] ch = str.ToCharArray();
            //for (int i = ch.Length-1; i >=0; i--)
            //{
            //    str1 += ch[i];
            //}
            //if (str==str1)
            //{
            //    Console.WriteLine("P");
            //}
            //else
            //{
            //    Console.WriteLine("NP");
            //}
        //    string a = "aqiba";
        //    Console.WriteLine("First no repeated is {0}",ch(a));
        //}
        //public static int numberOf(string str, char ch)
        //{
        //    int count = 0;
        //    char[] arr = str.ToCharArray();
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i]==ch)
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
            int temp = 0;
            int[] arr = new int[10];
            Console.WriteLine("Enter array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            temp = repeat(arr);
            Console.WriteLine("missing is {0}",temp);
        }

        public static char ch(string a)
        {
            char c1 = 'a';
            
            foreach (char item in a)
            {
                if(a.LastIndexOf(item) == a.IndexOf(item))
                {
                    return item;
                }
            }
            
            return c1;
        }

        public static int searchh(int [] arr)
        {
            int a = 1;
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] ==a)
                {
                    a++;
                }
                
            }

            
            return a;
        }

        public static int repeat(int [] arr, int [] dubval)
        {
            int a = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if(arr[i]==arr[j] && i!=j)
                    {
                        a = arr[i];
                    }
                }
                
            }
            return a;
        }

    }
}
