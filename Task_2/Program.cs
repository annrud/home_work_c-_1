﻿Console.Clear();
Console.WriteLine("Программа определяет max и min из двух чисел.");

Console.Write("Введите первое число: ");
string input1 = Console.ReadLine();    
int number1 = int.Parse(input1);

Console.Write("Введите второе число: ");
string input2 = Console.ReadLine(); 
int number2 = int.Parse(input2);

if (number1 > number2)
{
    Console.WriteLine($"max={number1} min={number2}");
}
else
{
    Console.WriteLine($"max={number2} min={number1}");
}
