// Задача 21: Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 2D пространстве.

Random rand = new Random();
int x1 = rand.Next(1,10);
int x2 = rand.Next(10,100);
int y1 = rand.Next(1,10);
int y2 = rand.Next(10,100);

/*
int x1 = 2;
int x2 = 5;
int y1 = 5;
int y2 = 9;
*/

Console.WriteLine($"Координаты точки А [{x1};{y1}]");
Console.WriteLine($"Координаты точки B [{x2};{y2}]");

Console.Write($"Расстояние между точками равно:");
Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2-y1, 2)));
