// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

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
