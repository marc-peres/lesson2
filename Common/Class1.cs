namespace Common;
public static class Helper
{
    public static int[,] GetRandom2dArr(int rows, int columns)
    {
        int[,] result = new int[rows, columns];
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = GetRandom(-10, 10);
            }
        }
        return result;
    }
    public static int GetRandom(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max + 1);
    }
    public static void PrintArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]}, ");
        }
        Console.WriteLine();
    }

    public static void PrintArr(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]}, ");
        }
        Console.WriteLine();
    }

    public static void PrintArr(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public static int PrintElementBy2dArr(int[,] arr, int rowPosition, int columnPosition)
    {
        int rows = arr.GetLength(0);
        int col = arr.GetLength(1);
        int result = -1;
        if (rowPosition >= 0 & rowPosition < rows & columnPosition >= 0 & columnPosition < col)
        {
            result = arr[rowPosition, columnPosition];
        }
        return result;
    }

    public static void PrintAverageBy2dArrCol(int[,] arr)
    {
        int sumByCol = 0;
        double average = 0;
        if (arr.GetLength(0) == 0 | arr.GetLength(1) == 0)
        {
            Console.WriteLine("массив пуст");
            return;
        }
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                sumByCol += arr[j, i];
            }
            Console.WriteLine($"среднее арифметическое столбца {i + 1} = {Math.Round((double)sumByCol / arr.GetLength(0), 2)}");
            sumByCol = 0;
            average = 0;
        }
    }
}
