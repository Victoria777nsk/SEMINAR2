// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number2 > Number1)
{
    if (Number2 % Number1 == 0)
    {
        Console.WriteLine($"Число {Number2} кратно числу {Number1}");
    }
    else
    {
        int result = Number2 % Number1;
        Console.WriteLine($"Число {Number2} НЕ кратно числу {Number1}, остаток от деления = {result}");
    }
}
else
{
    Console.WriteLine($"{Number2} < {Number1}");
}
