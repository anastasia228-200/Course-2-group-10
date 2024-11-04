////практика а
////задача1
using System;
class Program
{
    //static void Main()
    //{
    //    int num1 = Console.ReadLine();
    //    int num2 = Console.ReadLine();

    //    int sum = Sum(num1, num2);

    //    Console.WriteLine("Сумма " + num1 + " и " + num2 + " равна " + sum);
    //}
    //static int Sum(int a, int b)
    //{
    //    return a + b; // Возвращаем сумму двух чисел
    //}

    ////задача2
    //static void Main()
    //{
    //    Console.WriteLine("Введите ваше имя:");
    //    string userName = Console.ReadLine();

    //    GreetUser(userName); 
    //}

    //static void GreetUser(string name)
    //{
    //    Console.WriteLine("Привет, " + name + "! Добро пожаловать!"); 
    //}

    ////задача3
    //static void Main()
    //{
    //    Console.WriteLine("Введите первое число:");
    //    int number1 = Convert.ToInt32(Console.ReadLine()); 

    //    Console.WriteLine("Введите второе число:");
    //    int number2 = Convert.ToInt32(Console.ReadLine()); 

    //    int largerNumber = GetLargerNumber(number1, number2); 
    //    Console.WriteLine("Большее число: " + largerNumber); 
    //}

    //static int GetLargerNumber(int num1, int num2)
    //{
    //    return (num1 > num2) ? num1 : num2; 
    //}

    ////задача4
    //static void Main()
    //{
    //    Console.WriteLine("Введите число:");
    //    int number = Convert.ToInt32(Console.ReadLine()); 

    //    bool isEven = IsEven(number); 
    //    if (isEven)
    //    {
    //        Console.WriteLine("Число является четным.");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Число является нечетным.");
    //    }
    //}

    //static bool IsEven(int num)
    //{
    //    return num % 2 == 0; 
    //}

    ////задача5
    //static void Main()
    //{
    //    Console.WriteLine("Введите температуру в Цельсиях:");
    //    double celsius = Convert.ToDouble(Console.ReadLine()); 

    //    double fahrenheit = CelsiusToFahrenheit(celsius); 
    //    Console.WriteLine($"{celsius}°C равно {fahrenheit}°F");
    //}

    //static double CelsiusToFahrenheit(double celsius)
    //{
    //    return (celsius * 9 / 5) + 32;
    //}

    ////задача6
    //static void Main()
    //{
    //    Console.WriteLine("Введите строку:");
    //    string input = Console.ReadLine(); 
    //    string reversed = ReverseString(input); 
    //    Console.WriteLine($"Обратная строка: {reversed}");
    //}

    //static string ReverseString(string input)
    //{
    //    char[] charArray = input.ToCharArray(); 
    //    Array.Reverse(charArray); 
    //    return new string(charArray); 
    //}

    ////задача7
    //static void Main()
    //{
    //    Console.WriteLine("Введите строку:");
    //    string input = Console.ReadLine(); 

    //    Console.WriteLine("Введите символ для подсчета:");
    //    char characterToCount = Console.ReadKey().KeyChar; 
    //    Console.WriteLine(); 

    //    int count = CountCharacter(input, characterToCount); 
    //    Console.WriteLine($"Символ '{characterToCount}' встречается {count} раз(а) в строке.");
    //}

    //static int CountCharacter(string input, char character)
    //{
    //    int count = 0; 

    //    foreach (char c in input) 
    //    {
    //        if (c == character) 
    //        {
    //            count++; 
    //        }
    //    }

    //    return count; 
    //}

    ////задача8
    //static void Main()
    //{
    //    Console.WriteLine("Введите число для вычисления факториала:");
    //    int number;

    //    // Проверка корректности ввода числа
    //    while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
    //    {
    //        Console.WriteLine("Пожалуйста, введите неотрицательное целое число.");
    //    }

    //    long factorial = CalculateFactorial(number);
    //    Console.WriteLine($"Факториал числа {number} равен {factorial}.");
    //}

    //static long CalculateFactorial(int n)
    //{
    //    if (n == 0 || n == 1) 
    //    {
    //        return 1;
    //    }

    //    long factorial = 1; 
    //    for (int i = 2; i <= n; i++) 
    //    {
    //        factorial *= i; 
    //    }

    //    return factorial; 
    //}

    ////задача9
    //static void Main()
    //{
    //    Console.WriteLine("Введите число для проверки, является ли оно простым:");
    //    int number = int.Parse(Console.ReadLine());

    //    bool isPrime = IsPrime(number);
    //    if (isPrime)
    //    {
    //        Console.WriteLine($"Число {number} является простым.");
    //    }
    //    else
    //    {
    //        Console.WriteLine($"Число {number} не является простым.");
    //    }
    //}

    //static bool IsPrime(int n)
    //{
    //    if (n < 2) 
    //    {
    //        return false;
    //    }

    //    for (int i = 2; i <= Math.Sqrt(n); i++) 
    //    {
    //        if (n % i == 0) 
    //        {
    //            return false;
    //        }
    //    }

    //    return true; 
    //}

    ////задача10
    //static void Main()
    //{
    //    Console.WriteLine("Введите минимальное значение диапазона:");
    //    int min = Convert.ToInt32(Console.ReadLine());

    //    Console.WriteLine("Введите максимальное значение диапазона:");
    //    int max = Convert.ToInt32(Console.ReadLine());

    //    // Проверка корректности диапазона
    //    if (min >= max)
    //    {
    //        Console.WriteLine("Минимальное значение должно быть меньше максимального значения.");
    //        return;
    //    }

    //    int randomNumber = GenerateRandomNumber(min, max);
    //    Console.WriteLine($"Случайное число в диапазоне [{min}, {max}]: {randomNumber}");
    //}

    //static int GenerateRandomNumber(int min, int max)
    //{
    //    Random random = new Random();
    //    return random.Next(min, max + 1); // Генерация числа от min до max включительно
    //}

}