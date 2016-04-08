using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Class1
    {
        public void push(ref int[] array, ref int top,int a)
        {
            top++;
            array[top] = a;
        }
        public int pop(ref int[] array,ref int top)
        {
            int a = array[top];
            top--;
            return a;
        }
        
    }
}
