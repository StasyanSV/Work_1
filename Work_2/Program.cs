﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int number_3 = int.Parse(Console.ReadLine());

int max = number_1;

if (max < number_2)
{
    max = number_2;
}
if (max < number_3)
{
    max = number_3;
}

Console.Write("максимальное число из введеных: " + max);