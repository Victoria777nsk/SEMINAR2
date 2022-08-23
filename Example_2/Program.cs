// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46

int number = new Random().Next(100, 1000);

int result = ((number / 100) * 10) + (number % 10);

Console.WriteLine($"Number = {number}. Result = {result}");

