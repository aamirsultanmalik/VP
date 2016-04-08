using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    delegate void voidDelegate();//delegate for void methods
    delegate int intDelegate(int x,int y);//delegate for int return type with parameter
    public class methodClass
    {
        int x;
        public int MyProperty {
            get
            {
                return x;
            }
            set
            {
                x=value;
            }
        }
        public int[] this t
        {
            get;
            set;
        }
        string name;
        public void getInput()
        {
            Console.WriteLine("Please Enter Name");
            name = Console.ReadLine();
        }
        public void printInput()
        {
            Console.WriteLine("Your Name Is {0}",name);
        }
        public int add(int a, int b)
        {
            return a + b;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            methodClass obj_methodClass = new methodClass();//object for class
            voidDelegate obj_voidDelegate = new voidDelegate(obj_methodClass.getInput);//obj for delegate which will handle voi methods
            obj_voidDelegate();//calling method through object of delegate
            obj_voidDelegate = new voidDelegate(obj_methodClass.printInput);//assigning new voi method to same voi delegate
            obj_voidDelegate();//calling
            intDelegate obj_intDelegate = new intDelegate(obj_methodClass.add);//obj for delegate, reference to particular method
            obj_intDelegate(2, 2);//calling
        }
    }
}
