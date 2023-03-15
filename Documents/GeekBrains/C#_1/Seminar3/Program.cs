// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

string stringNumber = Convert.ToString(number);

if (stringNumber[0]==stringNumber[4] || stringNumber[1]==stringNumber[3])
{
    Console.Write("Палиндром");
}
else
{
    Console.Write("Не палиндром");
}

// // Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите X точки A");
// int XA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y точки A");
// int YA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Z точки A");
// int ZA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите X точки B");
// int XB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y точки B");
// int YB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Z точки B");
// int ZB = Convert.ToInt32(Console.ReadLine());

// double number = Math.Sqrt((Math.Pow((XB - XA),2))+(Math.Pow((YB - YA),2))+(Math.Pow((ZB - ZA),2)));

// Console.Write(number);



// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число");
// int number1 = Convert.ToInt32(Console.ReadLine());

// int i = 1;

// while (i <= number1)
// {
//     Console.Write(Math.Pow(i,3) + " ");
//     ++i;
// }