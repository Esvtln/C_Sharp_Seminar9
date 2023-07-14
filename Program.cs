// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// string PrintNumbers(int start, int end)
// {
//     if(start <= end) return ($"{end}");
//     return (start + " " + PrintNumbers(start - 1,end));
// }

// int number = InputNum("Введите натуральное число: ");
// Console.WriteLine(PrintNumbers(number, 1));


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// void SumNumber(int numberM, int numberN, int sum)
// {
//     if (numberM > numberN)
//     {
//         Console.WriteLine($"Сумма равна: {sum}");
//         return;
//     }
//     sum = sum + (numberM++);
//     SumNumber(numberM, numberN, sum);
// }

// int numberM = InputNum("Введите минимальное натуральное число: ");
// int numberN = InputNum("Введите максимальное натуральное число: ");
// SumNumber(numberM, numberN, 0);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void Akkerman(int m, int n)
{
    Console.Write(AkkermanFunction(m, n));
}

int AkkermanFunction(int m, int n)
{
    if (m == 0) return (n + 1);
    else if (n == 0 && m > 0) return AkkermanFunction(m - 1, 1);
    else return (AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)));

}

int m = InputNum("Введите число M: ");
int n = InputNum("Введите число N: ");
Akkerman(m, n);