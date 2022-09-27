// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введи количество строк: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[a, b];

Console.Write("Введи индекс строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи индекс столбца: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
    array[i,j] = new Random().Next(1,10);
    Console.Write($"{array[i, j]} ");
    }
Console.WriteLine();
}
if(m < a && n < b)
{
    Console.Write("Значение элемента заданной позиции: " + array[m, n]);
}
else
{
    Console.WriteLine($"{m}{n} - такого числа в массиве нет");
}