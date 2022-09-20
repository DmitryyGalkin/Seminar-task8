Console.Clear();

Console.WriteLine("Введите число: ");
string input = Console.ReadLine()!;
int number = int.Parse(input);

if (number <= 0)
{
    Console.WriteLine("введите положительное число");
}

int count = 2;
while (count <= number)
{
    
    {
        Console.Write($"{count} ");
    }
    count +=2;
}
