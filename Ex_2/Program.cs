//По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);

if (numberA == Math.Pow(numberB, 2))
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
if (numberB == Math.Pow(numberA, 2))
{
    Console.WriteLine("Второе число является квадратом первого");
}
else
{
    Console.WriteLine("Второе число не является квадратом первого");
}