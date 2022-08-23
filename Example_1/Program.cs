// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 85 -> 8

// using System;

// namespace Seminar2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }



int number = new Random().Next(10, 100);
int number1 = number % 10;
int number2 = number / 10;

int max = number1;

if (number2 > number1)
    {
        max = number2;
    }

Console.WriteLine($"Number {number} Max {max}");

