using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Task1()
        {
            Random rnd = new Random();

            int[] numbers = new int[1000];

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rnd.Next(1, 10);
                    Console.Write(numbers[i]);

                        if (i < 1000 - 1)
                        {
                            Console.Write(", ");
                        }
                }


            int[] count = new int[10];

                for (int i = 0; i < numbers.Length; i++)
                {
                    count[numbers[i]]++;
                }


            int minCount = count[1];
            int result = 1;

                for (int i = 2; i <= 9; i++)
                {
                    if (count[i] < minCount)
                    {
                        minCount = count[i];
                        result = i;
                    }
                }

            Console.WriteLine("\n\nЧисло, яке найменше повторювалося: " + result);
            Console.WriteLine("Кількість повторень: " + minCount);
        }


        static void Task2()
        {
            int size = input("Введіть розмір масиву: ");

            int min = input("Введіть початок діапазону (Від): ");

            int max = input("Введіть кінець діапазону (До): ");


            int[] numbers = new int[size];
            Random rnd = new Random();

                for (int i = 0; i < size; i++)
                {
                    numbers[i] = rnd.Next(min, max + 1);
                }

            Console.WriteLine("\nЗгенерований масив: ");
                for (int i = 0; i < size; ++i)
                {
                    Console.Write(numbers[i]);

                        if (i < size - 1)
                        {
                            Console.Write(", ");
                        }
                }

            HashSet<int> uniqueSet = new HashSet<int>();
                foreach (int num in numbers)
                {
                    uniqueSet.Add(num);
                }

            int[] result = new int[uniqueSet.Count];
            uniqueSet.CopyTo(result);

            Console.WriteLine("\n\nМасив без дублікатів: ");
                for (int i = 0; i < result.Length; ++i)
                {

                    Console.Write(result[i]);

                        if (i < result.Length - 1)
                        {
                            Console.Write(", ");
                        }
                }
        }


        static void Task3()
        {
            Random rnd = new Random();

            int size = input("Введіть довжину масиву:  \n");

            int[] numbers = new int[size];

            for (int i = 0;i < size; ++i)
            {
                numbers[i] = rnd.Next(100, 901);
            }

            Console.WriteLine("\nІндекси піків: ");

            for( int i = 0; i < size; i++)
            {
                if (i == 0)
                {
                    if (numbers[i] >= numbers[i + 1])
                    {
                        Console.WriteLine(i + " ");
                    }
                }
                else if (i == size -1)
                {
                    if (numbers[i] >= numbers[i - 1])
                    {
                        Console.WriteLine(i + " ");
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
        }


        static int input(string text)
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Виберіть задачу (1 , 2 , 3 , 4 , 5):");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Task1();
                    break;

                case "2":
                    Task2();
                    break;

                case "3":
                    Task3();
                    break;
            }

        } 
    }
}
