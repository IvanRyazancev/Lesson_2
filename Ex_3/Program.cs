//Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Введите номер четверти: ");
int PartNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введенный номер четверти: " + PartNumber);

if (PartNumber == 1)
{
    Console.WriteLine("Диапазон возможных координат (+ x; +y)");
}
else if (PartNumber == 2)
{
    Console.WriteLine("Диапазон возможных координат (- x; +y)");
}
else if (PartNumber == 3)
{
    Console.WriteLine("Диапазон возможных координат (- x; -y)");
}
else if (PartNumber == 4)
{
    Console.WriteLine("Диапазон возможных координат (+ x; -y)");
}
else
{
    Console.WriteLine("Введено некорректное значение четверти!");
}