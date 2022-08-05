/*  Задача 66. Задайте значения M и N. Напишите программу, 
 которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

using System;
using static System.Console;
Clear();

WriteLine("Введите стартовое число: ");
int m = Convert.ToInt32(ReadLine());
WriteLine("Введите число N: ");
int n = Convert.ToInt32(ReadLine());
WriteLine(SumNumbers (m,n));

int SumNumbers (int start, int end)
{
    return start <=end? (start + (SumNumbers (start+1, end))):0;
}