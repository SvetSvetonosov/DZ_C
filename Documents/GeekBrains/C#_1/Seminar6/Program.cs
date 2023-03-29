// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Console.WriteLine("Введите числа");

// int[] array = Console.ReadLine().Split(" ").Select(i => int.Parse(i)).ToArray();
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine(String.Join(", ", array));
// Console.WriteLine(String.Join(", ", count));


// // Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b1 - b2)/(k2 - k1);
double y = (k2 * x + b2);

Console.WriteLine("Координаты: "+" "+"("+x+" , "+y+")");

if ((k1==k2) && (b1==b2))
{
    Console.WriteLine("Прямые совпадают");
}
else if (k1==k2)
{
    Console.WriteLine("Прямые параллельны");
}
