Console.Clear();
Console.WriteLine("Программа выдаёт чётные числа от 1 до введённого числа.");

Console.Write("Введите число: ");
string input = Console.ReadLine();    
int number = int.Parse(input);

for (int i = 2; i <= number; i += 2)
{
    Console.Write(i);
    if (i + 1 < number)
    {
        Console.Write(", ");
    }
}
