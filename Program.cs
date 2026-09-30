using System;

namespace massivy_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;
            try
            {
                int sum = 0;
                int[] arrayA = new int[10]; // объявление массива
                for (int i = 0; i < arrayA.Length; i++)
                {
                    Console.Write($"Введите {i} элемент массива: ");
                    string str = Console.ReadLine();
                    if (Int32.TryParse(str, out int resultConvert)) // конвертация мб выполнена if (!Int32.TryParse(str, out int resultConvert)) - проверка на false
                    {
                        arrayA[i] = resultConvert;
                        sum += arrayA[i]; // накопление суммы
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введено недопустимое значение!");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.BackgroundColor = ConsoleColor.White;
                        i--;
                    }
                }
                Console.Write("Результирующий массив: ");
                int j = 0;
                while (j < arrayA.Length)
                {
                    Console.Write(j + " ");
                    j++;
                }
                Console.Write($"\nСумма элементов массива: {sum}");
                Console.ReadKey();
            }
            catch (IndexOutOfRangeException)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Red;
            }

        }
    }
}
