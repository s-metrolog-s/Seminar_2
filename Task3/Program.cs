// 12. Напишите программу, которая будет принимать 
// на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Random rand = new Random();
int number1 = rand.Next(100, 1000);
int number2 = rand.Next(100, 1000);
Console.WriteLine($"{number1}{":"}{number2}");

if (number1%number2 == 0)
{
    Console.WriteLine("Первое число кратно второму");
}
else
{
    Console.WriteLine($"{number1} не кратно {number2}, и остаток равен {number1%number2}");
}
