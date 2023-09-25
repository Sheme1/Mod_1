using System;
using System.Numerics;

namespace Alantev_mod1;


class Vivod
{
    static void Main(string[] args)
    {
        factorial.factorial_vivod();
        Sum_Chisl.sum_chisl_vivod();
        Revers.revers_vivod();
        Sred_Masiv.sred_masiv_vivod();
        Prost_chisl.prost_chisl();
    }
    
}
class factorial {

    public static void factorial_vivod()
    {
        try
        {
            Console.WriteLine("Введите число");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            BigInteger z = 1;
            for (int i = 1; i <= y; i++)
            {
                z = z * i;
            }
            Console.WriteLine($"Факториал числа {y} равен {z}");
            Console.WriteLine();    
        }
        
        
        catch 
        {
            
            Console.WriteLine("Введите целое число");
            Console.WriteLine();
            factorial_vivod();
        }
       

    }
}

class Sum_Chisl
{
    public static void sum_chisl_vivod()
    {
        try
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Введите первое число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введите второе число");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int z = x + y;
            Console.WriteLine($"Сумма чисел {x} и {y} равна {z}");
        }
        catch
        {
            Console.WriteLine("Введите целое число");
            Console.WriteLine();
            sum_chisl_vivod();
        }
    }
}

class Revers
{
    public static void revers_vivod()
    {
        try
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Введите строку");
            string s = (Console.ReadLine());
            if (string.IsNullOrEmpty(s))
            {
                throw new ArgumentException();
            }
            char[] strRevers = s.ToCharArray();
            Array.Reverse(strRevers);
            s = new string(strRevers);
            Console.WriteLine();
            Console.WriteLine($"Обратная строка: {s}");
        }
        catch
        {
            Console.WriteLine("Строка не может быть пустой");
            revers_vivod();
            Console.WriteLine();
        }
    }
}

class Sred_Masiv
{
    public static void sred_masiv_vivod()
    {
        int[] arr = new int[15];
        Random random = new Random();
        int z = 0;
        double x = 0;
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(-100,100);
            if (arr[i] > 0)
            {
                z = z + arr[i];
                count++;
                x = z / count;
            }
        }
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine();
        Console.Write("Элементы массива: ");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine($"\nСумма всех положительных элементов массива: {z}");
        Console.WriteLine($"\nСреднее занчение: {x}");
    }
}

class Prost_chisl
{
    public static void prost_chisl()
    {
        try
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Введите число");
            int x = Convert.ToInt32(Console.ReadLine());
            if (Prost(x))
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не простое");
            }
        }
        catch
        {
            Console.WriteLine("Введите число");
            prost_chisl();
        }
    }
    private static bool Prost(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(num));// нахождим корень числа и округляем в меньшую сторону

        for (int i = 3; i <= boundary; i += 2)// проверка на деление нацело числа
            if (num % i == 0)
                return false;

        return true;
    }
}
