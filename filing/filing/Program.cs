using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filing
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream fs = new FileStream(@"C:\Users\Aamir Sultan Malik\Desktop\a.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            //for (int i = 98; i < 127; i++)
            //{
            //    byte a = (byte)i;
            //    fs.WriteByte(a);
            //}
            //for (int i = 0; i < 27; i++)
            //{
            //    char a = (char)fs.ReadByte();
            //    Console.WriteLine(a);
            //}
            string[] str = File.ReadAllLines(@"C:\Users\Aamir Sultan Malik\Desktop\Program.cs");
            File.WriteAllLines(@"C:\Users\Aamir Sultan Malik\Desktop\a.txt", str);
        }
    }
}
