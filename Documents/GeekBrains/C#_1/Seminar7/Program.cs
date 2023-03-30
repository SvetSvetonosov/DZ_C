// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] array = new double [rows, columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0,10);
//         Console.Write(array[i,j]+" ");
//     }
//     Console.WriteLine();
// }


// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите число");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [5, 5];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,100);
        Console.Write(array[i,j]+" ");
    }
    Console.WriteLine();
}
if ((rows < 5) && (columns < 5))
{
    Console.Write(array[rows,columns]+" ");
}
else
{
    Console.WriteLine("Нет числа");
}



// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// double [,] array = new double [4, 4];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0,10);
//         Console.Write(array[i,j]+" ");
//     }
//     Console.WriteLine();
// }
// double sum1 = (array[0,0] + array[1,0] + array[2,0] + array[3,0])/4;
// double sum2 = (array[0,1] + array[1,1] + array[2,1] + array[3,1])/4;
// double sum3 = (array[0,2] + array[1,2] + array[2,2] + array[3,2])/4;
// double sum4 = (array[0,3] + array[1,3] + array[2,3] + array[3,3])/4;
// Console.WriteLine($"Среднее арифметическое каждого столбца: {sum1}, {sum2},{sum3}, {sum4} ");
