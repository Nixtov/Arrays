using System;
using System.Linq;

namespace exersise2
{
    public class Program
    {
        public static void Main()
        {
            string[] firstArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int lenght = Math.Min(firstArr.Length, secondArr.Length);
            int count = 0;

            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
}
            Array.Reverse(firstArr);
            Array.Reverse(secondArr);

            Console.WriteLine(count);
        }
        private static int FindMaxCommonItems(string[] secondArr, string[] firstArr);
    }
}

