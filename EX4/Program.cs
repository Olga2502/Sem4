//Написать программу вычисления произведения чисел от 1 до N

Console.Clear();
Console.WriteLine("Введите число : ");
int a = int.Parse(Console.ReadLine()!);
int b = 1;

if(a > 1)
{
    for(int i = 1; i <= a; i++)
    {
    b = b * i;
    //Console.WriteLine($"Произведение чисел от 1 до {i} равно  {b}");
    }
    Console.WriteLine($"Произведение чисел от 1 до {a} равно  {b}");
}
else
{
   //for(int i = 1; i >= a; i--)
   //{
    //b = b * i;
    //Console.WriteLine($"Произведение чисел от 1 до {i} равно  {b}");
    //}
    Console.WriteLine($"Произведение чисел от 1 до {a} равно  0"); 
}