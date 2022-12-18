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
//     PrintNumArr(numArr);
//     double x = (double)(numArr[2] - numArr[0]) / (numArr[1] - numArr[3]);
//     // int x = numArr[3] * x + numArr[2];
//     double y = numArr[3] * x + numArr[2];
//     Console.WriteLine($"X - {x}");
//     Console.WriteLine($"Y - {y}");
//     return $"({x};{y})";
// }

// void PrintStrArr(string[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
// }
// void PrintNumArr(int[] arr)
// {
//     Console.WriteLine();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
// }

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

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3 78 -> 2 89126 -> 5

// bool isParsed = int.TryParse(Console.ReadLine(), out int val);

// if (!isParsed)
// {
//     Console.WriteLine("Не число!");
//     return;
// }

// int res = CountOfNumbers(val);
// Console.WriteLine($"{res} - цифр(ы)");
// int CountOfNumbers(int val)
// {
//     int result = 0;
//     int copyOfNum = val;

//     while (copyOfNum > 9)
//     {
//         copyOfNum = copyOfNum / 10;
//         result += 1;
//     }
//     return result + 1;
// }

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4->24 5->120

// bool isParsed = int.TryParse(Console.ReadLine(), out int val);

// if (!isParsed)
// {
//     Console.WriteLine("Не число!");
//     return;
// }

// int res = FindeProductOfInterval(val);
// Console.WriteLine(res);
// int FindeProductOfInterval(int val)
// {
//     int i = 1;
//     int result = 1;
//     if (val == 0)
//     {
//         return 0;
//     }
//     while (i <= val)
//     {
//         result = result * i;
//         i++;
//     }
//     return result;
// }

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]



// Random random = new Random();

// int[] result = GetBenaryArr(8);
// PrintResult(result);


// int[] GetBenaryArr(int count)
// {
//     int[] resultArr = new int[count];
//     int i = 0;
//     while (i < count)
//     {
//         int num = random.Next(0, 2);
//         resultArr[i] = num;
//         i++;
//     }
//     return resultArr;
// }

// void PrintResult(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
// }








// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// bool isInt = int.TryParse(Console.ReadLine(), out int val);

// if (isInt & val >= 10000 & val < 100000)
// {

// }
// int[] result = DoArrByNum(val);

// bool isNumPalendromResult = IsPalindrom(result);
// if (isNumPalendromResult)
// {
//     Console.WriteLine($"Число {val} - палиндром");
// }
// else
// {
//     Console.WriteLine($"Число {val} - НЕ палиндром");
// }
// int[] DoArrByNum(int num)
// {
//     int[] arr = new int[5];
//     int result;
//     int newNum = num;
//     int i = 0;
//     while (i < 5)
//     {
//         result = newNum % 10;
//         arr[4 - i] = result;
//         newNum = newNum / 10;
//         i++;
//     }
//     return arr;
// }
// bool IsPalindrom(int[] arr)
// {
//     bool result = true;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] != arr[arr.Length - 1 - i])
//         {
//             result = false;
//             break;
//         }
//     }
//     return result;
// }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// bool isParsedAx = int.TryParse(Console.ReadLine(), out int ax);
// bool isParsedAy = int.TryParse(Console.ReadLine(), out int ay);
// bool isParsedAz = int.TryParse(Console.ReadLine(), out int az);
// bool isParsedBx = int.TryParse(Console.ReadLine(), out int bx);
// bool isParsedBy = int.TryParse(Console.ReadLine(), out int by);
// bool isParsedBz = int.TryParse(Console.ReadLine(), out int bz);

// if (!isParsedAx || !isParsedAy || !isParsedAz || !isParsedBx || !isParsedBy || !isParsedBz)
// {
//     Console.WriteLine("Введите корректные значения");
// }
// double result = FindeDistance(ax, ay, az, bx, by, bz);
// Console.WriteLine($"Растояние = {result}");
// double FindeDistance(int ax, int ay, int az, int bx, int by, int bz)
// {
//     return Math.Round(Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay) + (bz - az) * (bz - az)), 2);
// }


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// bool isParsedVal = int.TryParse(Console.ReadLine(), out int Val);

// if (!isParsedVal)
// {
//     Console.WriteLine("Введите корректные значения");
// }

// int[] result = GetSquareArr(Val);
// ShowResultByArr(result);
// int[] GetSquareArr(int val)
// {
//     int i = 1;
//     int[] resultArr = new int[val];
//     while (i <= val)
//     {
//         resultArr[i - 1] = (int)Math.Pow(i, 3);
//         i += 1;
//     }
//     return resultArr;
// }

// void ShowResultByArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.WriteLine(arr[i]);
//     }
// }







// показать вторую цифру трехзначного числа
// Random random = new Random();
// int num = random.Next(100, 1000);
// Console.WriteLine(num);
// int firstAndSecond = num / 10;
// int result = firstAndSecond % 10;
// Console.WriteLine(result);

// показать третью цифру любого числа если есть

// int userNum = int.Parse(Console.ReadLine());
// Console.WriteLine(userNum);
// int ThirdNum(int num)
// {
//     if (num < 100)
//     {
//         return -1;
//     }
//     else if (num < 1000)
//     {
//         return num % 10;
//     }
//     else
//     {
//         return ThirdNum(num / 10);
//     }
// }
// int result = ThirdNum(userNum);
// if (result == -1)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     Console.WriteLine($"Третьея цифра - {result}");
// }

// является ли день выходным

// bool isParsed = int.TryParse(Console.ReadLine(), out int usrDay);
// string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
// if (isParsed)
// {
//     if (usrDay > 0 & usrDay < 8)
//     {
//         if (usrDay == 6 | usrDay == 7)
//         {
//             Console.WriteLine($"{daysOfWeek[usrDay - 1]} - ура, выходной");
//         }
//         else
//         {
//             Console.WriteLine($"{daysOfWeek[usrDay - 1]} - рабочий день");
//         }
//     }
//     else
//     {
//         Console.WriteLine("В неделе всего 7 дней");
//     }
// }
// else
// {
//     Console.WriteLine("Введите число");
// }

/*
Решение в группах задач:
Задача 18: Напишите программу, которая по заданному номеру 
четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/

// bool isParsedQuoter = int.TryParse(Console.ReadLine(), out int quoter);

// if (!isParsedQuoter)
// {
//     Console.WriteLine("Введите число");
// }

// string result = GetDiapazonByQuoter(quoter);
// Console.WriteLine(result);

// string GetDiapazonByQuoter(int quoter)
// {
//     if (quoter == 1)
//     {
//         return "X больше ноля, Y больше ноля";
//     }
//     if (quoter == 2)
//     {
//         return "X больше ноля, Y меньше ноля";
//     }
//     if (quoter == 3)
//     {
//         return "X меньше ноля, Y меньше ноля";
//     }
//     if (quoter == 4)
//     {
//         return "X меньше ноля, Y больше ноля";
//     }
//     return "Error";
// }

/*
Задача 21: Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 2D пространстве.
 
A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21
*/

// bool isParsedA = double.TryParse(Console.ReadLine(), out double a);
// bool isParsedB = double.TryParse(Console.ReadLine(), out double b);
// bool isParsedC = double.TryParse(Console.ReadLine(), out double c);
// bool isParsedD = double.TryParse(Console.ReadLine(), out double d);

// if (!isParsedA || !isParsedB || !isParsedC || !isParsedD)
// {
//     Console.WriteLine("Введите корректные значения");
// }
// double result = FindeDistance(a, b, c, d);
// Console.WriteLine($"Растояние = {result}");
// double FindeDistance(double x1, double y1, double x2, double y2)
// {
//     return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
// }

/*
Задача 22: Напишите программу, которая принимает на
 вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
 int[] array =  
5 -> 1, 4, 9, 16, 25. 2 -> 1,4
*/

// bool isParsedVal = int.TryParse(Console.ReadLine(), out int Val);

// if (!isParsedVal)
// {
//     Console.WriteLine("Введите корректные значения");
// }

// int[] result = GetSquareArr(Val);
// ShowResultByArr(result);
// int[] GetSquareArr(int val)
// {
//     int i = 1;
//     int[] resultArr = new int[val];
//     while (i <= val)
//     {
//         resultArr[i - 1] = (int)Math.Pow(i, 2);
//         i += 1;
//     }
//     return resultArr;
// }

// void ShowResultByArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.WriteLine(arr[i]);
//     }
// }