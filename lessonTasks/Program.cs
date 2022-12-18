using static Common.Helper;

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите кол-во строк");
// bool isRowsCountInt = int.TryParse(Console.ReadLine(), out int rowsCount);
// Console.WriteLine("Введите кол-во столбцов");
// bool isColumnsCountInt = int.TryParse(Console.ReadLine(), out int columnsCount);
// if (!isColumnsCountInt | !isRowsCountInt)
// {
//     Console.WriteLine("некоректное значение");
// return;
// }
// int[,] result2dArr = GetRandom2dArr(rowsCount, columnsCount);
// PrintArr(result2dArr);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите номер строки");
// bool isRowsCountInt = int.TryParse(Console.ReadLine(), out int rowsNum);
// Console.WriteLine("Введите номер столбца");
// bool isColumnsCountInt = int.TryParse(Console.ReadLine(), out int columnsNum);
// if (!isColumnsCountInt | !isRowsCountInt)
// {
//     Console.WriteLine("некоректное значение");
//     return;
// }
// int[,] result2dArr = GetRandom2dArr(GetRandom(2, 10), GetRandom(2, 10));
// PrintArr(result2dArr);
// int searchResult = PrintElementBy2dArr(result2dArr, rowsNum, columnsNum);

// if (searchResult == -1)
// {
//     Console.WriteLine("такого числа в массиве нет");
// }
// else
// {
//     Console.WriteLine($"это число - {searchResult}");
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] result2dArr = GetRandom2dArr(GetRandom(2, 10), GetRandom(2, 10));
// PrintArr(result2dArr);
// PrintAverageBy2dArrCol(result2dArr);