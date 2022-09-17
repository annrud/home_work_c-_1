Console.Clear();
Console.WriteLine("Программа определяет max из трёх чисел.");

Console.Write("Введите первое число: ");
string input1 = Console.ReadLine();    
int number1 = int.Parse(input1);

Console.Write("Введите второе число: ");
string input2 = Console.ReadLine(); 
int number2 = int.Parse(input2);

Console.Write("Введите третье число: ");
string input3 = Console.ReadLine(); 
int number3 = int.Parse(input3);

if (number1 > number2 & number1 > number3)
{
    Console.WriteLine($"max={number1}");
}
else if (number2 > number1 & number2 > number3)
{
    Console.WriteLine($"max={number2}");
}
else
{
    Console.WriteLine($"max={number3}");
}
