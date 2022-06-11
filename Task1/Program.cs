// 1. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа

Random rand = new Random();
int number = rand.Next(10, 100);
Console.WriteLine(number);

int digit1 = number/10;
Console.WriteLine(digit1);
int digit2 = number%10;
Console.WriteLine(digit2);

if (digit1 > digit2)
{
    Console.WriteLine(digit1);
}
else
{
    Console.WriteLine(digit2);
}