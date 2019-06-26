using System;
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
        static void Main(string[] args)
        {
            int[] input = IntList("", 2); //Ввод количества роботов и года
            int robots = input[0]; //Присвоение роботов
            int years = input[1]; //Присвоение годов
            int[] array = new int[years + 1]; //Массив количества сделанных роботов на каждом году
            array[1] = robots; // На первом году было "robots" роботов
            int sum = 0; //Сумма роботов
            for(int i = 2; i < years + 1; i++) // Цикл от двух до years
            {
                sum = 0; 
                for(int x = i-1; x> i - 4; x--) // Сумирование роботов за предыдущие три года
                {
                    if (x >= 1)
                        sum += array[x];
                }
                int max = 0;
                
                for(int n3 = 0; n3 < 5; n3++) //Подсчет максимально возможного количества сделанных роботов
                    //Подсчет идет от 0 до 4, так как больше 4 групп по три робота делать нецелесообразно
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
