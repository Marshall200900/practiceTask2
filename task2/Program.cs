﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        public static int[] IntList(string sentence, int size, double minBorder = double.MinValue, double maxBorder = double.MaxValue)
        {
            int[] array = null;
            bool ok = true;
            do
            {
                Console.Write(sentence);
                try
                {
                    array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                    foreach (int a in array)
                    {
                        if (a < minBorder || a > maxBorder)
                        {
                            ok = false;
                            break;
                        }
                    }

                }
                catch (Exception)
                {
                    ok = false;
                }

            }
            while (!ok);
            return array;
        }
        public static double Double(string sentence, double minBorder = double.MinValue, double maxBorder = double.MaxValue)
        {
            double result = 0;
            bool ok = true;
            do
            {
                Console.Write(sentence);
                ok = double.TryParse(Console.ReadLine(), out result);
                if (result < minBorder || result > maxBorder)
                {
                    ok = false;
                }
            }
            while (!ok);
            return result;
        }
        public static int Int(string sentence, int minBorder = int.MinValue, int maxBorder = int.MaxValue)
        {
            int result = 0;
            bool ok = true;
            do
            {
                Console.Write(sentence);
                ok = int.TryParse(Console.ReadLine(), out result);
                if (result < minBorder || result > maxBorder)
                {
                    ok = false;
                }
            }
            while (!ok);
            return result;
        }
        static void Main(string[] args)
        {
            int[] input = IntList("", 2);
            int robots = input[0];
            int years = input[1];
            int[] array = new int[years + 1];
            array[1] = robots;
            int sum = 0;
            for(int i = 2; i < years + 1; i++)
            {
                sum = 0;
                for(int x = i-1; x> i - 4; x--)
                {
                    if (x >= 1)
                        sum += array[x];
                }
                int max = 0;
                for(int n3 = 0; n3 < 5; n3++)
                {
                    if (n3 * 3 <= sum)
                    {
                        int n5 = (sum - n3 * 3) / 5;
                        if (n3 * 5 + n5 * 9 > max)
                            max = n3 * 5 + n5 * 9;
                    }
                }
                array[i] = max;
            }
            sum = 0;
            for(int i = years; i > years - 3; i--)
            {
                if (i >= 1)
                    sum += array[i];
            }
            Console.WriteLine(sum);
                
        }
    }
}
