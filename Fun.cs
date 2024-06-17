using System;

public class SUM
{
    public static void Main()
    {
        int num1 = 55;
        int num2 = 110;

        int result = Sum(num1, num2);
        Console.WriteLine("Сумма чисел " + num1 + " и " + num2 + " равна " + result);
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}

class RADIUS
{
    static double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    static void Main()
    {
        Console.WriteLine("Введите радиус окружности:");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = CalculateCircleArea(radius);

        Console.WriteLine($"Площадь окружности: {area}");
    }
}

class DLINA
{
    static int GetStringLength(string inputString)
    {
        return inputString.Length;
    }

    static void Main()
    {
        string input = "!dlroH olleH";
        int length = GetStringLength(input);

        Console.WriteLine("Длина строки: " + length);
    }
}
class BOLSHE
{
    static int FindMaxValue(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Массив не может быть пустым");
        }

        int max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }

    static void Main()
    {
        int[] numbers = { 100, 50, 30, 155, 81 };
        int maxValue = FindMaxValue(numbers);

        Console.WriteLine("Наибольшее значение в массиве: " + maxValue);
    }
}

class FACTORIAL
{
    static long Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Введено отрицательное число");
        }

        long result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine("Введите число: ");
        int input = int.Parse(Console.ReadLine());

        long factorial = Factorial(input);

        Console.WriteLine("Факториал числа " + input + " равен " + factorial);
    }
}

class PROVERKA
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        if (Pal(input))
        {
            Console.WriteLine("Введенная строка является палиндромом.");
        }
        else
        {
            Console.WriteLine("Введенная строка не является палиндромом.");
        }
    }

    static bool Pal(string str)
    {
        str = str.ToLower().Replace(" ", "");
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}

class DVAMASS
{
    static int[] MergeArrays(int[] arr1, int[] arr2)
    {
        int[] mergedArray = new int[arr1.Length + arr2.Length];
        Array.Copy(arr1, 0, mergedArray, 0, arr1.Length);
        Array.Copy(arr2, 0, mergedArray, arr1.Length, arr2.Length);
        return mergedArray;
    }

    static void Main()
    {
        int[] array1 = { 11, 24, 36 };
        int[] array2 = { 423, 556, 62 };

        int[] result = MergeArrays(array1, array2);

        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
}
class TRUEFALSE
{
    static bool Proverka(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        Console.WriteLine("Введите число:");
        int num = Convert.ToInt32(Console.ReadLine());

        bool isproverka = Proverka(num);

        if (isproverka)
        {
            Console.WriteLine($"{num} - простое число.");
        }
        else
        {
            Console.WriteLine($"{num} - не простое число.");
        }
    }
}
class NAOBOROT
{
    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void Main()
    {
        string input = "!dlroW olleH";
        string reversed = ReverseString(input);
        Console.WriteLine(reversed);
    }
}
class SUMMASS
{
    public static void Main(string[] args)
    {
        int[,] numbers = {

          {14, 122, 33},
            {44, 56, 68},
            {73, 81, 95}
        };

        int sum = CalculateSum(numbers);
        Console.WriteLine("Сумма всех элементов в двумерном массиве: " + sum);
    }

    public static int CalculateSum(int[,] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j];
            }
        }
        return sum;
    }
}
