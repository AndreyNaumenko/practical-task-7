// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

Console.Write("Введи индекс строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи индекс столбца: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[m,n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
    array[i,j] = new Random().Next(-10,10);
    Console.Write($"{array[i, j]} ");
    }
Console.WriteLine();
}