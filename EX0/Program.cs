//Подсчитать сумму цифр в числе

Console.Clear();
Console.WriteLine("Введите число : ");
int a = int.Parse(Console.ReadLine()!);
int cont = 1;

while(a >= 10 || a <= -10 )
{
    a = a / 10;
    cont ++;
}
Console.WriteLine($"Количество цифр {cont}");