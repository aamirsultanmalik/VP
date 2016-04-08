using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPMidsAssignments
{
    [AttributeUsage(AttributeTargets.All)]
    public class Student : Attribute
    {
        public string name { get; set; }
        public int age { get; set; }
    }
    [Student(name="Aamir",age=21)]
    public class MyTestClass
    {
        [Student(name = "Aamir", age = 21)]
        public void myMethod()
        {
            
        }
    }
    class Program
    {
        public delegate int del(int x, int y);
        static void Main(string[] args)
        {
            del d;
            d = delegate(int x, int y)
            {
                return x + y;
            };
            Console.WriteLine("add delegate returns {0}",d(2,2));
            d = new del(sub);
            Console.WriteLine("sub delegate returns {0}",d(2,2));
        }
        public static int add(int a,int b)
        {
            return a + b;
        }

        public static int sub(int a, int b)
        {
            return a - b;
        }
    }
}
