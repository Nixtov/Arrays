using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] test = new int [5];
            test [2] = 2;
            
                for (int i = 0; i < test.Length; i++)
                {
                Console.WriteLine(test[i]);
                }
            

        }
    }
}
