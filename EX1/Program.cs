// // Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

Console.Clear();
Console.WriteLine("Введите число : ");
int a = int.Parse(Console.ReadLine()!);
int sm =  0;

if(a > 0)
{
    for (int i = 0; i <= a; i++)
    {
        sm = sm + i;    
    }

}

else
{
    for (int i = 0; i >= a; i--)
    {
        sm = sm + i;
    }
}

Console.WriteLine($"Сумма чисел   {sm} ");