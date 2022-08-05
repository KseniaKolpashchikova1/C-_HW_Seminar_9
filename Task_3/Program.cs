/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
 */

using System;
using static System.Console;
Clear();

WriteLine("Введите число m: ");
int n = Convert.ToInt32(ReadLine());
WriteLine("Введите число n: ");
int m = Convert.ToInt32(ReadLine());
WriteLine(AckFunction(m,n));

int AckFunction( int a, int b)
{
return (a == 0)? b+1
:((a > 0) && (b == 0))? AckFunction(a-1, 1)
:((a > 0) && (b > 0))? AckFunction(a-1, AckFunction(a, b-1)):0;
}
