// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A");
int number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int number2=Convert.ToInt32(Console.ReadLine());

if (number2 > 0)
{
    Console.WriteLine(Math.Pow(number1,number2));
}
else if (number2 < 0)
{
    Console.WriteLine("Показатель не должен быть меньше нуля");
}



// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число");
// int number1=Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (number1 > 0)
// {
//     sum += number1 %10;
//     number1 /= 10;
// }
// Console.Write("Сумма цифр:" + sum);



// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] array = new int [8];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0,10);
//     Console.WriteLine(array[i]);
// }
