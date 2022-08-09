// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


int a, b, c;
Console.WriteLine("Ввод a: ");
a = int.Parse(Console.ReadLine().ToString());
Console.WriteLine("Ввод b: ");
b = int.Parse(Console.ReadLine().ToString());
Console.WriteLine("Ввод c: ");
c = int.Parse(Console.ReadLine().ToString());
if (a > b && a > c) // && (Логические И, А ТАКЖЕ) инициирует выполнение инструкций
{
    Console.WriteLine($"a = {a}; b = {b}; c = {c} -> max a = {a}"); // -> присваивание
}
else
if (b > a && b > c)
{
    Console.WriteLine($"a = {a}; b = {b}; c = {c} -> max b = {b}");
}
else
if (c > a && c > b)
{
    Console.WriteLine($"a = {a}; b = {b}; c = {c} -> max c = {c}");
}
else
{
    Console.WriteLine($"a = {a}; b = {b}; c = {c} -> a = b = c = {a}");
}
