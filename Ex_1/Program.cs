using System.Security.Cryptography;
//Дано число обозначающее день недели. Выяснить является ли номер дня недели выходным

List<string> week = new List<string>();
{
    week.Add("Понедельник");
    week.Add("Вторник");
    week.Add("Среда");
    week.Add("Четверг");
    week.Add("Пятница");
    week.Add("Суббота");
    week.Add("Воскресенье");
}

int number_day = new Random().Next(1,7);
Console.WriteLine("Сгенерированный номер дня недели:" + number_day);

if (number_day >= 6 && number_day <= 7 )
{
    Console.Write("Название дня недели: " + week[number_day-1]);
    Console.Write(" - это выходной день.");    
}
else
{
    Console.Write("Название дня недели: " + week[number_day-1]);
    Console.Write(" - это будний день.");
}