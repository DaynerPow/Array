using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public static class DayLibary
    {
        public static int Input(string text)
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int[] GenerateArray(int size, int min, int max)
        {
            Random rnd = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(min, max + 1);
            }

            return array;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);

                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        public static void PrintPeaks(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    if (numbers[i] >= numbers[i + 1])
                    {
                        Console.Write(i + " ");
                    }
                }
                else if (i == numbers.Length - 1)
                {
                    if (numbers[i] >= numbers[i - 1])
                    {
                        Console.Write(i + " ");
                    }
                }
                else
                {
                    if (numbers[i] >= numbers[i - 1] && numbers[i] >= numbers[i + 1])
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
