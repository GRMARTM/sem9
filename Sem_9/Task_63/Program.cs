/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.
*/

Console.Write("Введите значение:");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumbers(1, N));

string PrintNumbers(int start, int end)
{
    if (start == end) return Convert.ToString(start);
    return (start + " " + PrintNumbers(start + 1, end));
}