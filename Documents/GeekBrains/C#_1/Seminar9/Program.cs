// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число:");
// int N = Convert.ToInt32(Console.ReadLine());

// int count = 1;
// PrintNumber(N, count);

// void PrintNumber(int N, int count)
// {
//   if (count > N) return;
//   PrintNumber(N, count + 1);
//   Console.Write(count + ", ");
// }

// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine());
// int temp = m;

// if (m > n) 
// {
//   m = n; 
//   n = temp;
// }

// PrintSumm(m, n, temp = 0);

// void PrintSumm(int m, int n, int summ)
// {
//   summ = summ + n;
//   if (n <= m)
//   {
//     Console.Write($"Сумма элементов: {summ} ");
//     return;
//   }
//   PrintSumm(m, n - 1, summ);
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

int functionAkkerman = A(m, n);
int A(int m, int n)
{
  if (m == 0) 
  return n + 1;
  
  else if (n == 0) 
  return A(m - 1, 1);
  
  else 
  return A(m - 1, A(m, n - 1));
}
Console.Write($"Функция Аккермана = {functionAkkerman} ");