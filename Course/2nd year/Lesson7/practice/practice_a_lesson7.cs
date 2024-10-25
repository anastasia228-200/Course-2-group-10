using System;

class Program
{
    ////задача1
    //static long Factorial(int n)
    //{
    //    if (n == 1)  // Базовый случай: факториал 1 равен 1
    //    {
    //        return 1;
    //    }
    //    return n * Factorial(n - 1);  // Рекурсивный вызов
    //}

    //static void Main(string[] args)
    //{
    //    Console.WriteLine(Factorial(4));
    //}

    ////задача2
    //static int Fibonacci(int n)
    //{
    //    if (n <= 1) return n;
    //    else return Fibonacci(n - 1) + Fibonacci(n - 2);

    //}

    //static void Main(string[] args)
    //{
    //    int n = 8;
    //    Console.WriteLine(Fibonacci(n));
    //}

    ////задача3
    //static void Main()
    //{
    //    string original = Console.ReadLine();
    //    string reversed = ReverseString(original);
    //    Console.WriteLine(reversed);
    //}

    //static string ReverseString(string str)
    //{
    //    if (str.Length == 0)
    //        return str;

    //    return str[str.Length - 1] + ReverseString(str.Substring(0, str.Length - 1));
    //}


    ////задача4
    //static int SumArray(int[] arr, int length)
    //{
    //    if (length == 0)
    //        return 0;

    //    return arr[length - 1] + SumArray(arr, length - 1);
    //}
    //static void Main()
    //{
    //    int[] numbers = { 1, 2, 3, 4, 5 };
    //    int sum = SumArray(numbers, numbers.Length);
    //    Console.WriteLine($"Сумма элементов массива: {sum}");
    //}

    ////задача5
    //static void Main()
    //{
    //    Console.Write("Введите первое число: ");
    //    int a = int.Parse(Console.ReadLine());

    //    Console.Write("Введите второе число: ");
    //    int b = int.Parse(Console.ReadLine());

    //    int gcd = GCD(a, b);
    //    Console.WriteLine($"НОД чисел {a} и {b} равен: {gcd}");
    //}

    //static int GCD(int a, int b)
    //{
    //    if (b == 0)
    //        return a;

    //    return GCD(b, a % b);
    //}

    ////задача6
    //static bool Palindrome(string str)
    //{
    //    if (str.Length <= 1)
    //        return true;

    //    if (str[0] != str[str.Length - 1])
    //        return false;

    //    return Palindrome(str.Substring(1, str.Length - 2));
    //}

    //static void Main()
    //{
    //    Console.Write("Введите число: ");
    //    string str = Console.ReadLine();

    //    if (Palindrome(str))
    //        Console.WriteLine($"Число '{str}' является палиндромом");
    //    else
    //        Console.WriteLine($"Число '{str}' не является палиндромом");
    //}

    ////задача7
    //static void Main()
    //{
    //    int numDisks = 3;
    //    TowerOfHanoi(numDisks, 'A', 'C', 'B'); 
    //}

    //static void TowerOfHanoi(int n, char source, char target, char auxiliary)
    //{
    //    if (n == 1)
    //    {
    //        Console.WriteLine($"Переместите диск 1 с {source} на {target}");
    //        return;
    //    }

    //    TowerOfHanoi(n - 1, source, auxiliary, target);

    //    Console.WriteLine($"Переместите диск {n} с {source} на {target}");

    //    TowerOfHanoi(n - 1, auxiliary, target, source);
    //}

    ////задача8
    //static void Main()
    //{
    //    int[] set = { 1, 2, 3 };
    //    List<int> currentSubset = new List<int>();

    //    Console.WriteLine("Все подмножества:");
    //    GenerateSubsets(set, currentSubset, 0);
    //}

    //static void GenerateSubsets(int[] set, List<int> currentSubset, int index)
    //{
    //    Console.WriteLine("{" + string.Join(", ", currentSubset) + "}");

    //    for (int i = index; i < set.Length; i++)
    //    {
    //        currentSubset.Add(set[i]);

    //        GenerateSubsets(set, currentSubset, i + 1);

    //        currentSubset.RemoveAt(currentSubset.Count - 1);
    //    }
    //}

    //задача9


    //задача10
    //static void Main()
    //{
    //    string input = "abc";
    //    List<string> permutations = new List<string>();

    //    GeneratePermutations(input.ToCharArray(), 0, permutations);

    //    Console.WriteLine("Все перестановки:");
    //    foreach (string perm in permutations)
    //    {
    //        Console.WriteLine(perm);
    //    }
    //}

    //static void GeneratePermutations(char[] array, int index, List<string> result)
    //{
    //    if (index == array.Length - 1)
    //    {
    //        result.Add(new string(array)); // Добавляем перестановку в результат
    //        return;
    //    }

    //    for (int i = index; i < array.Length; i++)
    //    {
    //        Swap(ref array[index], ref array[i]); // Меняем местами
    //        GeneratePermutations(array, index + 1, result); // Рекурсивный вызов
    //        Swap(ref array[index], ref array[i]); // Возврат в исходное состояние (backtrack)
    //    }
    //}

    //static void Swap(ref char a, ref char b)
    //{
    //    char temp = a;
    //    a = b;
    //    b = temp;
    //}
}
