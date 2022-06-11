// 16. Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

int max;
int min;

if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}

if (max == min * min)
{
    Console.WriteLine($"Число {min} является квадратом {max}");
}
else
{
    Console.WriteLine($"Число {min} не является квадратом {max}");
}