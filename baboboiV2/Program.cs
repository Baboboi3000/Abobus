﻿using System.Buffers;

while (true)
{
    Console.WriteLine("Ведите первое число");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ведите второе число");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10)
    {
        Console.WriteLine("Оба числа должны быть в диапазоне от 0 до 10");
    }
    else
    {
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        break;
    }
}

