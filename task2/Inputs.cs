using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Inputs
    {
        public static int[] IntList(string sentence,int size, double minBorder = double.MinValue, double maxBorder = double.MaxValue)
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
    }
}
