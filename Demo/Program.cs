using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] nums = { 10, 20, 30 };
            foreach (var num in nums)
            {
                Console.Write(num);
                Console.Write(' ');

            }
        }
    }
}
