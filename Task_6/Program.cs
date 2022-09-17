Console.Clear();
Console.WriteLine("Программа определяет чётное ли число.");

Console.Write("Введите число: ");
string input = Console.ReadLine();    
int number = int.Parse(input);

if (number % 2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}