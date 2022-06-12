// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Random rand = new Random();
/*
Console.WriteLine("Введите координату x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y:");
int y = Convert.ToInt32(Console.ReadLine());
*/

int x = rand.Next(-10, 10);
int y = rand.Next(-10, 10);

Console.WriteLine();
//Console.WriteLine("[" + x + "; " + y + "]"); Первый способ отражения текста с переменными
Console.WriteLine($"[ {x}; {y} ]");

if (x == 0 || y == 0)
{
    Console.WriteLine("Введите ненулевые значения");
}
else
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Точка лежит в 1-ой четверти");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Точка лежит в 2-ой четверти");
    }
        else if (x < 0 && y < 0)
    {
        Console.WriteLine("Точка лежит в 3-ой четверти");
    }
        else if (x > 0 && y < 0)
    {
        Console.WriteLine("Точка лежит в 4-ой четверти");
    }
}