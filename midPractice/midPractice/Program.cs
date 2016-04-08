using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            string str;
            Console.WriteLine("Enter String");
            str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            string str2 = "";
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                str2 = str2 + ch[i].ToString();
            }
            if (str.Contains(str2))
            {
                Console.WriteLine("Palandrome {0}",str);
            }
            else
            {
                Console.WriteLine("Not Palandrome {0}",str2);
            }
            Console.WriteLine(string.Concat(str, str2)+"{0}",str
);
        }
        public override string ToString()
        {
            return string.Format("{0}+{1} Iam aamir");
        }
    }
}
