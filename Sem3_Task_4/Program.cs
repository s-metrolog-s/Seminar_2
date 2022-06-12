// Задача 21: Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 2D пространстве.
// Решение через массивы

int[] pointA = new int [2] {5, 9}; //объявление массива с заданием значений
int[] pointB = new int [2];

pointB[0] = 2;
pointB[1] = 5;

Console.WriteLine(Math.Sqrt(Math.Pow(pointA[0] - pointB[0], 2)
                          + Math.Pow(pointA[1] - pointB[1], 2)));