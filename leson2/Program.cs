// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// bool isParsedVal = int.TryParse(Console.ReadLine(), out int arrLength);

// if (!isParsedVal)
// {
//     Console.WriteLine("Не число!");
//     return;
// }

// int[] randomArr = RandomArr(arrLength);
// PrintArr(randomArr);
// int countOfEvenNum = EvenNumCount(randomArr);
// Console.Write($"Колличество положительных чисел - {countOfEvenNum}");

// int EvenNumCount(int[] userArr)
// {
//     int result = 0;
//     for (int i = 0; i < userArr.Length; i++)
//     {
//         if (userArr[i] % 2 == 0)
//         {
//             result += 1;
//         }
//     }
//     return result;
// }
// int[] RandomArr(int userArrLength)
// {
//     Random random = new Random();
//     int[] result = new int[userArrLength];
//     int i = 0;
//     while (i < userArrLength)
//     {
//         result[i] = random.Next(100, 1000);
//         i++;
//     }
//     return result;
// }
// void PrintArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
// }

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// bool isParsedVal = int.TryParse(Console.ReadLine(), out int arrLength);

// if (!isParsedVal)
// {
//     Console.WriteLine("Не число!");
//     return;
// }

// int[] randomArr = RandomArr(arrLength);
// PrintArr(randomArr);
// int evenElementsSum = SumOfEvenElements(randomArr);
// Console.Write($"Сумма елементов с четными индексами - {evenElementsSum}");

// int[] RandomArr(int userArrLength)
// {
//     Random random = new Random();
//     int[] result = new int[userArrLength];
//     int i = 0;
//     while (i < userArrLength)
//     {
//         result[i] = random.Next(1, 100);
//         i++;
//     }
//     return result;
// }
// int SumOfEvenElements(int[] arr)
// {
//     int result = 0;
//     int i = 0;

//     while (i < arr.Length)
//     {
//         if (i % 2 != 0)
//         {
//             result += arr[i];
//         }
//         i++;
//     }
//     return result;
// }
// void PrintArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
// }

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. Не использовать готовые методы Min и Max
// [3 7 22 2 78] -> 76

// bool isParsedVal = int.TryParse(Console.ReadLine(), out int arrLength);

// if (!isParsedVal)
// {
//     Console.WriteLine("Не число!");
//     return;
// }

// int[] randomArr = RandomArr(arrLength);
// PrintArr(randomArr);
// int maxMinSum = FindeSumOfMaxMin(randomArr);
// Console.Write($"Сумма max & min елементов - {maxMinSum}");

// int FindeSumOfMaxMin(int[] arr)
// {
//     int min = arr[0];
//     int max = arr[0];
//     int i = 0;
//     if (arr.Length == 0)
//     {
//         return 0;
//     }
//     while (i < arr.Length)
//     {
//         if (arr[i] < min)
//         {
//             min = arr[i];
//         }
//         if (arr[i] > max)
//         {
//             max = arr[i];
//         }
//         i++;
//     }
//     Console.WriteLine();
//     Console.WriteLine($"max - {max}");
//     Console.WriteLine($"min - {min}");
//     return min + max;
// }
// int[] RandomArr(int userArrLength)
// {
//     Random random = new Random();
//     int[] result = new int[userArrLength];
//     int i = 0;
//     while (i < userArrLength)
//     {
//         result[i] = random.Next(1, 100);
//         i++;
//     }
//     return result;
// }
// void PrintArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
// }

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.WriteLine($"Введите числа через пробел");
// string numbersStr = Console.ReadLine();
// string[] subs = numbersStr.Split(' ');
// PrintArr(subs);
// int positiveNumbers = CountOfPositiveNum(subs);
// Console.WriteLine($"Колличество положительных чисел - {positiveNumbers}");

// int CountOfPositiveNum(string[] arr)
// {
//     if (arr.Length == 0)
//     {
//         return 0;
//     }
//     int result = 0;
//     int i = 0;
//     while (i < arr.Length)
//     {
//         bool isParsedVal = int.TryParse(arr[i], out int intValue);
//         if (isParsedVal & intValue > 0)
//         {
//             result += 1;
//         }
//         i++;
//     }
//     return result;
// }
// void PrintArr(string[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
// }

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Console.WriteLine($"Введите значения координат b1, k1, b2 и k2 через пробел");
// string numbersStr = Console.ReadLine();
// string[] subs = numbersStr.Split(' ');
// PrintStrArr(subs);
// if (subs.Length < 4)
// {
//     Console.WriteLine($"Не корректные координаты");
//     return;
// }
// string point = FindePointOfIntersection(subs);
// Console.WriteLine($"Координыты точки пересечения - {point}");

// string FindePointOfIntersection(string[] arr)
// {
//     int[] numArr = new int[arr.Length];
//     int i = 0;
//     while (i < 4)
//     {
//         bool isParsedVal = int.TryParse(arr[i], out int intValue);
//         if (isParsedVal)
//         {
//             numArr[i] = intValue;
//         }
//         i++;
//     }
//     double x = (double)(numArr[2] - numArr[0]) / (numArr[1] - numArr[3]);
//     double y = numArr[3] * x + numArr[2];
//     return $"({x};{y})";
// }

// void PrintStrArr(string[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
// }
