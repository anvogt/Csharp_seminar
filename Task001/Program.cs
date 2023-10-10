﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");

int N = Convert.ToInt32(Console.ReadLine());

if(99 < N && N < 999)
{
    System.Console.WriteLine($"Вторая цифра числа: {(N%100) / 10}");
}

else {

     System.Console.WriteLine("Данное число не является трехзначным");
}