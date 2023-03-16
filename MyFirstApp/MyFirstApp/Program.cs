using System;
using System.Threading.Channels;
using System.Collections.Generic;

namespace MyFirstApp
{
    public class Program
    {
       
        public static void Main()
        {
            trialClass trialClass = new trialClass();
            trialClass.write();
        }
    }
}