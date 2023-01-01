using static Common.Helper;

// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("введите натуральное число");
// bool isUserNumInt = int.TryParse(Console.ReadLine(), out int userNum);
// if (!isUserNumInt | userNum < 1)
// {
//     Console.WriteLine("некоректное значение");
//     return;
// }
// Console.WriteLine("----------------");
// PrintAllNaturalNums(userNum);


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("введите натуральное число (начало промежутка)");
// bool isStartNumInt = int.TryParse(Console.ReadLine(), out int startNum);
// Console.WriteLine("введите натуральное число (конец промежутка)");
// bool isEndNumInt = int.TryParse(Console.ReadLine(), out int endNum);
// if (!isEndNumInt | !isStartNumInt | startNum < 1 | endNum < 1)
// {
//     Console.WriteLine("некоректное значение");
//     return;
// }
// int result;
// if (startNum < endNum)
// {
//     result = FindSumBetweenNum(startNum, endNum);
//     Console.WriteLine($"сумма натуральных чисел в промежутке между {startNum} и {endNum} ровна - {result}");
// }
// else
// {
//     result = FindSumBetweenNum(endNum, startNum);
//     Console.WriteLine($"сумма натуральных чисел в промежутке между {endNum} и {startNum} ровна - {result}");
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.WriteLine("введите натуральное число (начало промежутка)");
// bool isFirstNumInt = int.TryParse(Console.ReadLine(), out int firstNum);
// Console.WriteLine("введите натуральное число (конец промежутка)");
// bool isSecondNumInt = int.TryParse(Console.ReadLine(), out int secondNum);
// if (!isSecondNumInt | !isFirstNumInt | firstNum < 0 | secondNum < 0)
// {
//     Console.WriteLine("некоректное значение");
//     return;
// }

// int result = AckermanFunc(firstNum, secondNum);
// Console.WriteLine($"ответ = {result}");

// int AckermanFunc(int firstNum, int secondNum)
// {
//     if (firstNum == 0)
//     {
//         return secondNum + 1;
//     }
//     else
//     {
//         if (secondNum == 0)
//         {
//             return AckermanFunc(firstNum - 1, 1);
//         }
//         else
//         {
//             return AckermanFunc(firstNum - 1, AckermanFunc(firstNum, secondNum - 1));
//         }
//     }
// }
