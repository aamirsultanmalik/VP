using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new test();
            t.MyProperty = false;
            Console.WriteLine(t.MyProperty);
            Console.ReadLine();
        }
    }
    public class MyAttributes: Attribute
    {
        public int MyProperty { get; set; }
        
    }
    [MyAttributes(MyProperty=10)]
    public class test
    {
        public bool name= true;
        public bool MyProperty {
            
            get
            {
                return name;
            }
            set { name=value; }
        }
    }
}
