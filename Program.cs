﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine ("Ввведите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Ввведите число n");
int n = Convert.ToInt32(Console.ReadLine());
int GetAkkerman (int m, int n)
{
if (m == 0) 
{
return n+1;
}
else
{
if (n == 0)
{
 return GetAkkerman(m - 1,1);
} else {return GetAkkerman(m-1,GetAkkerman(m,n-1));}
}
}
Console.WriteLine ($"Ответ: {GetAkkerman (m, n)}");