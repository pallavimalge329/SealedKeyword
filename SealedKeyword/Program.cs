using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedKeyword
{
    sealed class SealedClass
    {

        // Calling Function
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    class Program
    {
       // Main Method
        static void Main(string[] args)
        {

            // Creating an object of Sealed Class
            SealedClass slc = new SealedClass();

            // Performing Addition operation
            int total = slc.Add(28, 40);
            Console.WriteLine("Total = " + total.ToString());
            Console.ReadLine();
        }
    }
}
