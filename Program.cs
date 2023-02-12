// See https://aka.ms/new-console-template for more information
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
int x = number1 % 2;
if (x > 0)
{
    System.Console.WriteLine(number1+"Нечетное");
}
else 
{
    System.Console.WriteLine(number1+"Четное");
}


