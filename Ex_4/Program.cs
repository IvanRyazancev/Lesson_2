//Найти расстояние между точками в пространстве 2D/3D

Console.Write("Выберите пространство для рассчета расстояния между точками А и В. 1)2D или 2)3D: "); //Нужно ввести 1 или 2
int argument = int.Parse(Console.ReadLine()!);

if (argument == 1) //Блок рассчета расстояния в 2D пространстве
{
    Console.Write("Введите координату x первой точки: ");
    int x1 = int.Parse(Console.ReadLine()!);
    Console.Write("Введите координату y первой точки: ");
    int y1 = int.Parse(Console.ReadLine()!);

    Console.Write("Введите координату x второй точки: ");
    int x2 = int.Parse(Console.ReadLine()!);
    Console.Write("Введите координату y второй точки: ");
    int y2 = int.Parse(Console.ReadLine()!);

    double rasstoyanie = Math.Pow((Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2)),0.5);  

    Console.WriteLine("Рассчет представлен для 2D пространства.");  
    if (rasstoyanie == 0)
    {        
        Console.WriteLine("Положение в пространстве точки A совпадает с положением точки B, так как расстояние между точками A и B: " + rasstoyanie);
    }
    else
    {
        Console.WriteLine("Расстояние между точкой A и точкой B: " + Math.Round(rasstoyanie,2));
    }    
}
else if (argument == 2) //Блок рассчета расстояния между точками в 3D пространстве
{
    Console.Write("Введите координату x первой точки: ");
    int x1 = int.Parse(Console.ReadLine()!);
    Console.Write("Введите координату y первой точки: ");
    int y1 = int.Parse(Console.ReadLine()!);
    Console.Write("Введите координату z первой точки: ");
    int z1 = int.Parse(Console.ReadLine()!);

    Console.Write("Введите координату x второй точки: ");
    int x2 = int.Parse(Console.ReadLine()!);
    Console.Write("Введите координату y второй точки: ");
    int y2 = int.Parse(Console.ReadLine()!);
    Console.Write("Введите координату z первой точки: ");
    int z2 = int.Parse(Console.ReadLine()!);

    double rasstoyanie = Math.Pow((Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2)+Math.Pow((z2 - z1),2)),0.5);    

    Console.WriteLine("Рассчет представлен для 3D пространства.");
    if (rasstoyanie == 0)
    {        
        Console.WriteLine("Положение в пространстве точки A совпадает с положением точки B, так как расстояние между точками A и B: " + rasstoyanie,2);
    }
    else
    {
        Console.WriteLine("Расстояние между точкой A и точкой B: " + Math.Round(rasstoyanie,2));
    }    
}
else
{
    Console.WriteLine("Введенное значение некорректно!");    
}