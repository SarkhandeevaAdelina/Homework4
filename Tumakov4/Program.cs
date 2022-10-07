using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dz51();
            Console.ReadKey();
        }
        public static void up51()
        {
            Console.Write("Введите первое число:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число:");
            int b = int.Parse(Console.ReadLine());
            int max = Maximum(a, b);
            Console.WriteLine("Максимальное число:{0}", max);
        }
        public static int Maximum(int a, int b)
        {
            return a > b ? a : b;
        }
        public static void up52()
        {
            Console.Write("Введите первое число a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a = {0}; b = {1}", a, b);
            Change(ref a, ref b);
            Console.WriteLine("a = {0}; b = {1}", a, b);
        }
        public static void Change(ref int a, ref int b)
        {
            (a, b) = (b, a); // обмен
        }
        public static void up53()
        {
            Console.Write("Введите число, факториал которого вы хотите найти a= ");
            int a = int.Parse(Console.ReadLine());
            bool ans = faktorial(ref a);
            Console.WriteLine(Convert.ToString(ans) + $"\nФакториал числа:{a}");
        }
        static bool faktorial(ref int num)
        {
            int c = num;
            num = 1;
            for (int i = 1; i <= c; i++)
                try
                {
                    checked
                    {
                        num *= i;
                    }
                }
                catch
                {
                    return false;
                }
            return true;
        }
        public static void up54()
        {
            Console.Write("Введите число, факториал которого вы хотите найти a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Искомый факториал равен:" + Factorial(a));
        }
        static int Factorial(int a)
        {
            if (a == 0) return 1;
            return a * Factorial(a - 1);
        }
        static void GetNOD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            Console.WriteLine("НОД двух чисел a и b: " + a);
        }
        static int GetNOD(int a, int b, int c)
        {
            int Nod = Math.Min(a, Math.Min(a, b));
            for (; Nod > 1; Nod--)
            {
                if (a % Nod == 0 && b % Nod == 0 && c % Nod == 0)
                    break;
            }
            return Nod;
        }

        public static void dz51()
        {
            Console.WriteLine("Написать метод, который вычисляет НОД двух/трех натуральных чисел");
            Console.Write("Введите первое число:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число:");
            int y = int.Parse(Console.ReadLine());
            GetNOD(x, y);
            Console.Write("Введите третье число:");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("НОД трех чисел a,b,c:"+ GetNOD(x, y, z));
        }

        public static void dz52()
        {
            Console.Write("Введите число n = ");
            int n = int.Parse(Console.ReadLine());
            int ans = Fibonachi(n);
            Console.Write($"{n}-ое число ряда фибоначи равно:{ans}");
        }
        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);//рекурсивным называется метод, возвращающий сам себя
            }

        }


    }

}
