﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("введите трехзначное целое число ");

int number = Convert.ToInt32(Console.ReadLine());

int secondRank = number / 10 % 10;

Console.Write ($"Вторая цифра `{secondRank}`");