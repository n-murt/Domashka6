// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System;
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine($"Количество чисел в массиве больше 0 - {Program.AboveZero(5)}");
    }

    static int AboveZero(int number1)
    {
        int[] array = new int[number1];
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите {i + 1} число : ");

            array[i] = Convert.ToInt32(Console.ReadLine());
            // Console.Write($"{array[i]} ");
        }

        for (int k = 0; k < array.Length; k++)
        {
            if (array[k] > 0)
            {
                count++;
            }
        }

        return (int)count;
    }

}