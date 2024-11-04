////дз
////задание 1
using System;

class Program
{
    //static void Main()
    //{
    //    int[] nums = { 1, 2, 3, 2, 5, 3, 2 };
    //    int mostFrequentElement = FindMostFrequentElement(nums);

    //    Console.WriteLine($"Элемент, который встречается чаще всего: {mostFrequentElement}");
    //}

    //static int FindMostFrequentElement(int[] nums)
    //{
    //    var frequencyMap = new Dictionary<int, int>();

    //    // Подсчет частоты каждого элемента
    //    foreach (var num in nums)
    //    {
    //        if (frequencyMap.ContainsKey(num))
    //        {
    //            frequencyMap[num]++;
    //        }
    //        else
    //        {
    //            frequencyMap[num] = 1;
    //        }
    //    }

    //    int mostFrequent = nums[0];
    //    int maxCount = 0;

    //    // Поиск элемента с максимальной частотой
    //    foreach (var kvp in frequencyMap)
    //    {
    //        if (kvp.Value > maxCount)
    //        {
    //            maxCount = kvp.Value;
    //            mostFrequent = kvp.Key;
    //        }
    //    }

    //    return mostFrequent;
    //}



    ////задание 2

    //static void Main()
    //{
    //    // Исходная матрица
    //    int[,] matrix = {
    //        { 1, 2, 3 },
    //        { 4, 5, 6 },
    //        { 7, 8, 9 }
    //    };

    //    Console.WriteLine("Исходная матрица:");
    //    PrintMatrix(matrix);

    //    // Транспонируем матрицу
    //    int[,] transposedMatrix = TransposeMatrix(matrix);

    //    Console.WriteLine("Транспонированная матрица:");
    //    PrintMatrix(transposedMatrix);
    //}

    //static int[,] TransposeMatrix(int[,] matrix)
    //{
    //    int rows = matrix.GetLength(0); // Количество строк
    //    int columns = matrix.GetLength(1); // Количество столбцов
    //    int[,] transposed = new int[columns, rows];

    //    // Перемещение элементов
    //    for (int i = 0; i < rows; i++)
    //    {
    //        for (int j = 0; j < columns; j++)
    //        {
    //            transposed[j, i] = matrix[i, j];
    //        }
    //    }

    //    return transposed;
    //}

    //static void PrintMatrix(int[,] matrix)
    //{
    //    int rows = matrix.GetLength(0);
    //    int columns = matrix.GetLength(1);

    //    for (int i = 0; i < rows; i++)
    //    {
    //        for (int j = 0; j < columns; j++)
    //        {
    //            Console.Write(matrix[i, j] + "\t");
    //        }
    //        Console.WriteLine();
    //    }
    //}
}



