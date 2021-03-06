﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums =
                Console.ReadLine().Split(' ')
                .Select(selector: double.Parse).
                ToArray();
            foreach (var x in nums)
            {
                double rounded = Math.Round(x, 0,
                    MidpointRounding.AwayFromZero);
                Console.WriteLine(x + " =" + rounded);
            }
        }
    }
}
