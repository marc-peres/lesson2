// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
//  Напишите программу, которая принимает на вход два числа (A и B) и метод который возводит число A в натуральную степень B. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать Math.Pow()
// bool isParsedVal = int.TryParse(Console.ReadLine(), out int val);
// bool isParsedDeg = int.TryParse(Console.ReadLine(), out int deg);
// if (!isParsedVal || !isParsedDeg)
// {
//     Console.WriteLine("Не число!");
//     return;
// }
// int res = ValInDegree(val, deg);
// Console.WriteLine(res);

// int ValInDegree(int val, int deg)
// {
//     int i = 2;
//     int result = val;
//     if (deg == 0)
//     {
//         return 1;
//     }
//     while (i <= deg)
//     {
//         result = result * val;
//         i++;
//     }
//     return result;
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// bool isParsedVal = int.TryParse(Console.ReadLine(), out int val);
// if (!isParsedVal)
// {
//     Console.WriteLine("Не число!");
//     return;
// }
// int res = GetSum(val);
// Console.WriteLine(res);
// int GetSum(int val)
// {
//     int newVal = val;
//     int result = 0;
//     while (newVal > 0)
//     {
//         result += newVal % 10;
//         newVal = newVal / 10;
//     }
//     return result;
// }

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// bool isParsedLength = int.TryParse(Console.ReadLine(), out int lengthOfArr);
// bool isParsedMin = int.TryParse(Console.ReadLine(), out int min);
// bool isParsedMax = int.TryParse(Console.ReadLine(), out int max);
// if (!isParsedLength || !isParsedMin || !isParsedMax)
// {
//     Console.WriteLine("Не число!");
//     return;
// }
// Random random = new Random();
// int[] res = BuildRandomArr(lengthOfArr, min, max);

// Console.WriteLine(String.Join(", ", res));

// int[] BuildRandomArr(int length, int min, int max)
// {
//     int[] result = new int[length];
//     int i = 0;
//     while (i < length)
//     {
//         result[i] = random.Next(min, max + 1);
//         i++;
//     }
//     return result;
// }
