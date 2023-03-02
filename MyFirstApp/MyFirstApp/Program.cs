using System;
using System.Collections;

namespace MyFirstApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayList x = new ArrayList();
            ArrayList y = new ArrayList(10);
            x.Add(1);
            y.Add(2);
            x.Add("syed");
            x.Add(1.5);
            foreach (object item in x)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}