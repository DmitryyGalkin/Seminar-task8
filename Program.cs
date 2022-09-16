Console.Clear();

Console.WriteLine("Введите число: ");
string input = Console.ReadLine()!;
int number = int.Parse(input);

if(number <= 0)
{
    Console.WriteLine("введите положительное число");
}

int count = 1;
while(count <= number)
{
    if(count % 2 == 0)
    {
        Console.Write(count);
        Console.Write(", ");
    }
    count++;
}
