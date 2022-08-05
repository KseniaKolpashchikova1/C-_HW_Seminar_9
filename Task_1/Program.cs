/* Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет произведение натуральных чисел в промежутке от M до N.
M = 1; N = 5. ->120
M = 4; N = 6. -> 120 */

using System;
using static System.Console;
Clear();

WriteLine("Введите стартовое число: ");
int m = Convert.ToInt32(ReadLine());
WriteLine("Введите число N: ");
int n = Convert.ToInt32(ReadLine());
WriteLine(CompositionNumbers (m,n));

int CompositionNumbers (int start, int end)
{
    return start<=end?(start * (CompositionNumbers (start +1, end))):1;
}
