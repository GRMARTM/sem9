// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// from M to N

Console.Write("Введите стартовое значение:");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите финишное значение:");
int N = Convert.ToInt32(Console.ReadLine());



string PrintNumbers(int start, int end)
{
    if (start == end) return Convert.ToString(start);
    return (start + " " + PrintNumbers(start + 1, end));
}

Console.WriteLine($"Все натуральные числа от {M} до {N} : {PrintNumbers(M, N)}");
