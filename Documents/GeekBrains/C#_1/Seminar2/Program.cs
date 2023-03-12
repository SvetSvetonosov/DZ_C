// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.


// Console.WriteLine("Введите трехзначное число");
// int number1=Convert.ToInt32(Console.ReadLine());

// int number2 = (number1%100 - number1%10)/10 ;
// {
//     Console.WriteLine("Второе число: " + number2);
// }


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// Console.WriteLine("Введите число");
// int number1=Convert.ToInt32(Console.ReadLine());

// int number2 = (number1%1000 - number1%100)/100 ;

// if (number1 < 100)
// {
//     Console.WriteLine("Третьего числа нет");
// }
// else if (number1 > 100)
// {
//     Console.WriteLine("Третье число: " + number2);
// }



// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру дня недели");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 <= 5)
{
    Console.WriteLine("Не выходной день");
}
else if (number1 == 6 || number1 == 7)
{
    Console.WriteLine("Выходной день");
}
else 
{
    Console.WriteLine("Такого дня недели не существует");
}