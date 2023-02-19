//Возведите число А в натуральную степень B используя цикл

Console.Clear();
Console.WriteLine("Введите число : ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите степень: ");
int b = int.Parse(Console.ReadLine()!);

int c = 1;

if(b >= 0)
{
    for(int i = 1; i <= b; i++)
    {
        c *= a;
    }
    Console.WriteLine($"{c}");
}
else
{
    
    for(int i = 0; i >= b; i--)
    {
        c *= a;
    }
    Console.WriteLine($"1/{c}");
}
