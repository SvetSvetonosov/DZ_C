// Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.

// Console.WriteLine("Введите число");
// int number1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int number2=Convert.ToInt32(Console.ReadLine());

// if(number1>number2)
// {
//     Console.WriteLine("Минимальное: {0} Максимальное: {1}", number2, number1);
// }
// else if(number1<number2)
// {
//    Console.WriteLine("Минимальное: {0} Максимальное: {1}", number1, number2);
// }
// else
// {
//     Console.WriteLine("Числа равны: {0}", number1);
// }


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


// Console.WriteLine("Введите число");
// int number1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int number2=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int number3=Convert.ToInt32(Console.ReadLine());

// int max=number1;
// if(number2>max)
// {
//     max=number2;
// }
// if(number3>max)
// {
//     max=number3;
// }
// {
//     Console.WriteLine("Максимальное: {0}", max);
// }

// Напишите программу, которая на вход принимает число и выдаёт,
//  является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введите число");
// int number1=Convert.ToInt32(Console.ReadLine());

// if (number1%2==0)
// {
//    Console.WriteLine("Четное число"); 
// }
// else
// {
//    Console.WriteLine("Нечетное число"); 
// }

// Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int number1=Convert.ToInt32(Console.ReadLine());

int number2=1;

while (number2<number1)
{
    Console.WriteLine(number2+1);
    number2=number2+2;
}