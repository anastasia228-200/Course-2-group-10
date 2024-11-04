////практика в
////задание 1
using System;

class Program
{
    //static void Main()
    //{
    //    int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
    //    int[] result = FindMaxSubArray(arr);

    //    Console.WriteLine("Подмассив с максимальной суммой:");
    //    foreach (var num in result)
    //    {
    //        Console.Write(num + " ");
    //    }
    //}

    //static int[] FindMaxSubArray(int[] arr)
    //{
    //    if (arr.Length == 0) return new int[0];

    //    int maxSum = arr[0];
    //    int currentSum = arr[0];
    //    int start = 0, end = 0, tempStart = 0;

    //    for (int i = 1; i < arr.Length; i++)
    //    {
    //        // Если текущая сумма становится отрицательной, начинаем новый подпорядок
    //        if (currentSum < 0)
    //        {
    //            currentSum = arr[i];
    //            tempStart = i;
    //        }
    //        else
    //        {
    //            currentSum += arr[i];
    //        }

    //        // Обновляем максимальную сумму и индексы, если найдена новая максимальная сумма
    //        if (currentSum > maxSum)
    //        {
    //            maxSum = currentSum;
    //            start = tempStart;
    //            end = i;
    //        }
    //    }

    //    // Возвращаем подмассив с максимальной суммой
    //    int[] maxSubArray = new int[end - start + 1];
    //    Array.Copy(arr, start, maxSubArray, 0, end - start + 1);
    //    return maxSubArray;
    //}


    ////практика с
    //static void Main()
    //{
    //    int[] nums = { 1, 2, 3 };
    //    var permutations = GetPermutations(nums);

    //    Console.WriteLine("Все уникальные перестановки:");
    //    foreach (var perm in permutations)
    //    {
    //        Console.WriteLine(string.Join(", ", perm));
    //    }
    //}

    //static List<List<int>> GetPermutations(int[] nums)
    //{
    //    var result = new List<List<int>>();
    //    Permute(nums, 0, result);
    //    return result;
    //}

    //static void Permute(int[] nums, int start, List<List<int>> result)
    //{
    //    // Если достигнут конец массива, добавляем текущее состояние в результат
    //    if (start == nums.Length)
    //    {
    //        result.Add(new List<int>(nums));
    //        return;
    //    }

    //    for (int i = start; i < nums.Length; i++)
    //    {
    //        // Меняем текущий элемент с элементом на позиции start
    //        Swap(nums, start, i);
    //        // Рекурсивно вызываем перестановку для следующего элемента
    //        Permute(nums, start + 1, result);
    //        // Возвращаем массив в исходное состояние
    //        Swap(nums, start, i);
    //    }
    //}

    //static void Swap(int[] nums, int i, int j)
    //{
    //    int temp = nums[i];
    //    nums[i] = nums[j];
    //    nums[j] = temp;
    //}


}



