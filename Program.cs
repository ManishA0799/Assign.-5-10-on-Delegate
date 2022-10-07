using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CW_30_9
{
    public delegate string MyDelegate(string s1);
    public class Convert
    {
        public string UpperCase(string a)
        {
             return a.ToUpper();
        }
        public string LowerCase(string a)
        {
            return a.ToLower();
        }

        public class Program
        {
            static void Main(string[] args)
            {
                Convert c = new Convert();
                MyDelegate myDelegate = new MyDelegate(c.UpperCase);
                myDelegate += new MyDelegate(c.LowerCase);

                Delegate[] list = myDelegate.GetInvocationList();
                foreach (Delegate d in list)
                {
                    Console.WriteLine(d.Method);
                    Console.WriteLine(d.DynamicInvoke("manish"));

                }
            }

        }

    }
}




