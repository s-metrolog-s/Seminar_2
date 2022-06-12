// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите номер четверти:");
// int number = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();
int number = rand.Next(1,5);
Console.WriteLine($"Подобрана {number} четверть");

if (number == 1)
{
    Console.WriteLine("Точка лежит в пределах, где X > 0; Y > 0");
}
else if (number == 2) 
{
    Console.WriteLine("Точка лежит в пределах, где X < 0; Y > 0");
}
else if (number == 3)
{
    Console.WriteLine("Точка лежит в пределах, где X < 0; Y < 0");
}
else if (number == 4)
{
    Console.WriteLine("Точка лежит в пределах, где X > 0; Y < 0");
}
