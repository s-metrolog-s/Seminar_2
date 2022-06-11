//  11. Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.

Random rand = new Random();
int number = rand.Next(100, 1000);
Console.WriteLine(number);

//Console.Write(number.ToString()[0]);
//Console.Write(number.ToString()[2]);

Console.Write($"{number/100}{number%10}");