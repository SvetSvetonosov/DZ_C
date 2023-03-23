// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[10];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(99,1000);

    if (array[i]%2==0)
    {
        count++;
    }
}
Console.WriteLine(String.Join(", ", array));
Console.WriteLine(String.Join(", ", count));


// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int[10];
// int sum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0,10);
// }
// for (int i = 0; i < array.Length; i+=2)
// {
//     sum = sum + array[i]; 
// }

// Console.WriteLine(String.Join(", ", array));
// Console.WriteLine(String.Join(", ", sum));



// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] array= {4, 44, 55, 28, 5};

// double max = array[0];
// double min = array[0];

// for (int i = 0; i < array.Length; ++i)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     else if (array[i] < min)
//     {
//         min = array[i];
//     }
// }

// Console.WriteLine(String.Join(", ", array));
// Console.WriteLine(String.Join(", ", (max - min)));
