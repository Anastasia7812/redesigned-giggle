﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральную степень");

int degree = Convert.ToInt32(Console.ReadLine());

int  exponentiation=Exponentiation(number, degree);

Console.WriteLine($"-> {exponentiation} ");