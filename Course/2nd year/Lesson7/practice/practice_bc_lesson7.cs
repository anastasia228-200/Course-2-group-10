////практика в и с
////задание 11

using System;

class Program
{
    //static void Main()
    //{
    //    int[,] maze = {
    //        { 0, 1, 0, 0, 0 },
    //        { 0, 1, 0, 1, 0 },
    //        { 0, 0, 0, 1, 0 },
    //        { 0, 1, 0, 0, 0 },
    //        { 0, 0, 0, 1, 0 }
    //    };

    //    if (FindPath(maze, 0, 0))
    //    {
    //        Console.WriteLine("Найден путь в лабиринте");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Путь не найден.");
    //    }
    //}

    //static bool FindPath(int[,] maze, int x, int y)
    //{
    //    if (x == maze.GetLength(0) - 1 && y == maze.GetLength(1) - 1)
    //    {
    //        maze[x, y] = 2; // Отмечаем путь
    //        PrintMaze(maze);
    //        return true;
    //    }

    //    if (IsSafe(maze, x, y))
    //    {
    //        maze[x, y] = 2;

    //        if (FindPath(maze, x + 1, y)) // Вниз
    //            return true;
    //        if (FindPath(maze, x, y + 1)) // Вправо
    //            return true;
    //        if (FindPath(maze, x - 1, y)) // Вверх
    //            return true;
    //        if (FindPath(maze, x, y - 1)) // Влево
    //            return true;

    //        maze[x, y] = 0;
    //    }

    //    return false; 
    //}

    //static bool IsSafe(int[,] maze, int x, int y)
    //{
    //    return (x >= 0 && x < maze.GetLength(0) &&
    //            y >= 0 && y < maze.GetLength(1) &&
    //            maze[x, y] == 0);
    //}

    //static void PrintMaze(int[,] maze)
    //{
    //    Console.WriteLine("Текущий лабиринт:");
    //    for (int i = 0; i < maze.GetLength(0); i++)
    //    {
    //        for (int j = 0; j < maze.GetLength(1); j++)
    //        {
    //            if (maze[i, j] == 2)
    //                Console.Write(" * ");
    //            else
    //                Console.Write(" " + maze[i, j] + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //    Console.WriteLine();
    //}

    ////задание12

    //static void Main()
    //{
    //    int[] array = { 34, 7, 23, 32, 5, 62 };

    //    Console.WriteLine("Исходный массив:");
    //    PrintArray(array);

    //    QuickSort(array, 0, array.Length - 1);

    //    Console.WriteLine("Отсортированный массив:");
    //    PrintArray(array);
    //}

    //static void QuickSort(int[] array, int low, int high)
    //{
    //    if (low < high)
    //    {
    //        // Находим опорный элемент и разбиваем массив
    //        int pivotIndex = Partition(array, low, high);

    //        // Рекурсивно сортируем элементы перед и после опорного элемента
    //        QuickSort(array, low, pivotIndex - 1);
    //        QuickSort(array, pivotIndex + 1, high);
    //    }
    //}

    //static int Partition(int[] array, int low, int high)
    //{
    //    int pivot = array[high]; // Выбираем опорный элемент (последний элемент)
    //    int i = low - 1; // Индекс меньшего элемента

    //    for (int j = low; j < high; j++)
    //    {
    //        // Если текущий элемент меньше или равен опорному
    //        if (array[j] <= pivot)
    //        {
    //            i++; // Увеличиваем индекс меньшего элемента
    //            Swap(array, i, j);
    //        }
    //    }
    //    Swap(array, i + 1, high); // Помещаем опорный элемент на правильное место
    //    return i + 1; // Возвращаем индекс опорного элемента
    //}

    //static void Swap(int[] array, int i, int j)
    //{
    //    int temp = array[i];
    //    array[i] = array[j];
    //    array[j] = temp;
    //}

    //static void PrintArray(int[] array)
    //{
    //    foreach (int value in array)
    //    {
    //        Console.Write(value + " ");
    //    }
    //    Console.WriteLine();
    //}
}