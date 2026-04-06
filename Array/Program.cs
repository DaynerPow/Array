using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    internal class Program
    {
        static int Input(string text)
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int[] GenerateArray(int size, int min, int max)
        {
            Random rnd = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(min, max + 1);
            }

            return array;
        }

        static void PrintArray(int[] array)
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

        static void PrintPeaks(int[] numbers)
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

        static void Task1()
        {
            int[] numbers = GenerateArray(1000, 1, 9);

            PrintArray(numbers);

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

            Console.WriteLine("\nЧисло, яке найменше повторювалося: " + result);
            Console.WriteLine("Кількість повторень: " + minCount);
        }

        static void Task2()
        {
            try
            {
                int size = Input("Введіть розмір масиву:");
                int min = Input("Введіть початок діапазону (Від):");
                int max = Input("Введіть кінець діапазону (До):");

                int[] numbers = GenerateArray(size, min, max);

                Console.WriteLine("\nЗгенерований масив:");
                PrintArray(numbers);

                HashSet<int> uniqueSet = new HashSet<int>();

                foreach (int num in numbers)
                {
                    uniqueSet.Add(num);
                }

                int[] result = new int[uniqueSet.Count];
                uniqueSet.CopyTo(result);

                Console.WriteLine("\nМасив без дублікатів:");
                PrintArray(result);
            }
            catch
            {
                Console.WriteLine("!Невірний набір!");
            }
        }

        static void Task3()
        {
            try
            {
                int size = Input("Введіть довжину масиву:");

                int[] numbers = GenerateArray(size, 100, 900);

                Console.WriteLine("\nМасив:");
                PrintArray(numbers);

                Console.WriteLine("\nІндекси піків:");
                PrintPeaks(numbers);
            }
            catch
            {
                Console.WriteLine("!Невірний набір!");
            }
        }


        static void Task4()
        {
            try
            {
                Console.WriteLine("Напишіть любі англійські слова:");
                string words = Console.ReadLine().Trim();

                if (words.Length == 0)
                {
                    Console.WriteLine("!Немає слів!");
                    return;
                }

                int count = 1;

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] == ' ')
                    {
                        count++;
                    } 
                }

                Console.WriteLine("Кількість слів: " + count);

                string checkedChars = "";

                foreach (char c in words)
                {
                    bool alreadyChecked = false;

                    foreach (char checkedC in checkedChars)
                    {
                        if (c == checkedC)
                        {
                            alreadyChecked = true;
                            break;
                        }
                    }

                    if (!alreadyChecked)
                    {
                        int charCount = 0;

                        foreach (char target in words)
                        {
                            if (c == target)
                            {
                                charCount++;
                            }
                        }

                        Console.WriteLine("Символ '" + c + "' зустрічається: " + charCount + " разів");

                        checkedChars += c;
                    }
                }
            }
            catch
            {
                Console.WriteLine("!Невірний набір!");
            }
        }


        static void Task5()
        {
            GenerateArray(20, 10, 100);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Виберіть задачу (1, 2, 3, 4, 5):");
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

                case "4":
                    Task4();
                    break;

                case "5":
                    Task5();
                    break;

                default:
                    Console.WriteLine("!Невірний набір!");
                    break;
            }
        }
    }
}