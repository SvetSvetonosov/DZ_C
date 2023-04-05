// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int [rows, columns];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0,10);
//         Console.Write(array[i,j]+" ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int k = 0; k < array.GetLength(1)-1; k++)
//         {
//             if (array[i,k]<array[i,k+1])
//             {
//                 int temp = array[i,k+1];
//                 array[i,k+1] = array[i,k];
//                 array[i,k] = temp;
//             }
//         }
//     }
// }

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//     Console.Write(array[i,j]+" ");
//     }
//     Console.WriteLine();
// }


// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
//  выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Console.WriteLine("Введите число строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int [rows, columns];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0,10);
//         Console.Write(array[i,j]+" ");
//      }
//     Console.WriteLine();
// }

// int minSumLine = 0;
// int sumLine = SumLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumLine = SumLineElements(array, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSumLine = i;
//   }
// }

// Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой элементов ");

// int SumLineElements(int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
// }


// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int [,] array1 = new int [2, 2];

// for (int i = 0; i < array1.GetLength(0); i++)
// {
//     for (int j = 0; j < array1.GetLength(1); j++)
//     {
//         array1[i,j] = new Random().Next(0,10);
//         Console.Write(array1[i,j] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();

// int [,] array2 = new int [2, 2];

// for (int i = 0; i < array2.GetLength(0); i++)
// {
//     for (int j = 0; j < array2.GetLength(1); j++)
//     {
//         array2[i,j] = new Random().Next(0,10);
//         Console.Write(array2[i,j] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();

// int [,] array3 = new int [2, 2];

// for (int i = 0; i < array3.GetLength(0); i++)
// {
//     for (int j = 0; j < array3.GetLength(1); j++)
//     {
//         int sum = 0;
//         for (int k = 0; k < array3.GetLength(1); k++)
//         {
//             sum += array1[i,k]* array2[k,j];
//         }
//         Console.Write((array3[i,j] = sum) + " ");
//     }
//     Console.WriteLine();
// }
