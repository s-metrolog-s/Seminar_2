// Задача 22: Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Random rand = new Random();
int N = rand.Next(1, 10);
int count = 1;
Console.WriteLine($"Случайное число {N}");

while (count <= N)
{
    Console.WriteLine($"{count} * {count} -> {Math.Pow(count, 2)}");
    count ++;
}

Console.WriteLine();