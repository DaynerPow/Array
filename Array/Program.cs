using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    internal class Program
    {
        static void Task1()
        {
            int[] numbers = DayLibary.GenerateArray(1000, 1, 9);

            DayLibary.PrintArray(numbers);

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
                int size = DayLibary.Input("Введіть розмір масиву:");
                int min = DayLibary.Input("Введіть початок діапазону (Від):");
                int max = DayLibary.Input("Введіть кінець діапазону (До):");

                int[] numbers = DayLibary.GenerateArray(size, min, max);

                Console.WriteLine("\nЗгенерований масив:");
                DayLibary.PrintArray(numbers);

                HashSet<int> uniqueSet = new HashSet<int>();

                foreach (int num in numbers)
                {
                    uniqueSet.Add(num);
                }

                int[] result = new int[uniqueSet.Count];
                uniqueSet.CopyTo(result);

                Console.WriteLine("\nМасив без дублікатів:");
                DayLibary.PrintArray(result);
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
                int size = DayLibary.Input("Введіть довжину масиву:");

                int[] numbers = DayLibary.GenerateArray(size, 100, 900);

                Console.WriteLine("\nМасив:");
                DayLibary.PrintArray(numbers);

                Console.WriteLine("\nІндекси піків:");
                DayLibary.PrintPeaks(numbers);
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
            int[] array = DayLibary.GenerateArray(20, 10, 100);
            DayLibary.  PrintArray(array);

            int maxSum = array[0] + array[1] + array[2];
            int maxIndex = 0;

            for (int i = 1; i < array.Length - 2; i++)
            {
                int sum = array[i] + array[i + 1] + array[i + 2];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxIndex = i;
                }
            }

            Console.WriteLine("\nНайбільша сума: " + maxSum);

            Console.WriteLine("Індекси підмасиву: ");
            Console.WriteLine(maxIndex + ", " + (maxIndex +1) + ", " + (maxIndex + 2));

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