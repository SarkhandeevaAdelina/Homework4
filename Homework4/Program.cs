using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dolg1();
            Console.ReadKey();
        }
        static string GetX(int a, int b, int c)
        {
            int D = b * b - 4 * a * c;
            if (D > 0)
            {
                return ("x1= " + (-b + Math.Sqrt(D)) / (2 * a) + " x2= " + (-b - Math.Sqrt(D)) / (2 * a));
            }
            else if (D == 0)
            {
                return ("X: " + -b / 2 * a);
            }
            else
            {
                return ("Действительных корней нет");
            }
        }

        public static void Ex1()
        {
            Console.WriteLine("Задание1:написать метод для решения квадратного уравнения.");
            Console.Write("Введите первый коэффициент при x^2: a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второй коэффициент при x: b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третий свободный коэффициент : c = ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(GetX(a, b, c));

        }

        public static void Ex2()
        {
            Console.WriteLine("В массиве из 20 чисел поменять местами два числа, вывести на экран");
            int[] numbers = new int[20];
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next();
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine("\nВведите индексы через пробел элементов массива, которые нужно поменять местами:");
            string line = Console.ReadLine();
            string[] splitString = line.Split(' ');
            int a = Convert.ToInt32(splitString[0]);
            int b = Convert.ToInt32(splitString[1]);
            if (a == b)
            {
                Console.WriteLine("Нужно было ввести два разных числа!");
            }
            Console.WriteLine($"\nБудем менять местами элементы с индексами {a} и {b}");
            int num = numbers[a];
            numbers[a] = numbers[b];
            numbers[b] = num;
            Console.WriteLine("Список после перестановки двух элементов:");
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
        }
        static int[] BubbleSort(int[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] > s[j])
                    {
                        int a = s[i];
                        s[i] = s[j];
                        s[j] = a;

                    }
                }
            }
            return s;
        }
        public static void Ex3()
        {
            Console.WriteLine("Отсортировать одномерный массив  при помощи “пузырька”");
            Console.Write("Введите количество элементов в массиве: ");
            int a = int.Parse(Console.ReadLine());
            int[] s = new int[a];
            BubbleSort(s);
            Console.WriteLine("В результате сортировки был получен массив:");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
            Console.ReadLine();
        }
        static int Array_task4(out double average, ref double produ, params int[] mass)
        {
            average = 0;
            produ = 1;
            foreach (int i in mass)
            {
                produ *= i;
                average = produ / mass.Count();
            }
            return mass.Sum();
        }
        public static void Ex4()
        {
            double a;
            double b = 0;
            double c;
            Console.Write("Введите количество элементов массива: n = ");
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите {0}-й элемент массива:", i + 1);
                mass[i] = int.Parse(Console.ReadLine());
            }

            c = Array_task4(out a, ref b, mass);
            Console.WriteLine($"Сумма элементов массива: {c}\nCреднее арифметическое эдементов массива: {a}\nПроизведение элементов массива: {b}");

        }

        public static void Ex5()
        {
            Console.WriteLine("Введите число:");
            string s = Console.ReadLine();
            s = s.ToLower();
            try
            {
                int n = int.Parse(s);
                switch (n)
                {
                    case 1:
                        Console.WriteLine(" # \n" + "## \n" + " # \n" + " # \n" + "###");
                        break;
                    case 2:
                        Console.WriteLine(" # \n " + " # # \n " + "   # \n " + " # \n " + " ### ");
                        break;
                    case 3:
                        Console.WriteLine(" ## \n " + "   # \n " + " # \n " + "   # \n " + " ## ");
                        break;
                    case 4:
                        Console.WriteLine(" # # \n " + " # # \n " + " ### \n " + "   # \n " + "   # ");
                        break;
                    case 5:
                        Console.WriteLine(" ### \n " + " #   \n " + " ### \n " + "   # \n " + " ## ");
                        break;
                    case 6:
                        Console.WriteLine(" ## \n " + " #   \n " + " ### \n " + " # # \n " + " ### ");
                        break;
                    case 7:
                        Console.WriteLine(" ### \n " + "   # \n " + "   # \n " + " # \n " + " # ");
                        break;
                    case 8:
                        Console.WriteLine(" ### \n " + " # # \n " + " ### \n " + " # # \n " + " ### ");
                        break;
                    case 9:
                        Console.WriteLine(" ### \n " + " # # \n " + " ### \n " + "   # \n " + " ## ");
                        break;
                    case 0:
                        Console.WriteLine(" # \n " + " # # \n " + " # # \n " + " # # \n " + " # ");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка");
                        break;


                }

                if (s == "закрыть" || s == "exit")
                {
                }
                else if (int.TryParse(s, out var number) == true)
                {
                    int chisl = int.Parse(s);
                    if (chisl > 9 || chisl < 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("Выход за предел");
                        Thread.Sleep(3000);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();

                    }
                }
                else
                {
                    int chisl = int.Parse(s);
                }
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);//сообщает об ошибке, объявляя причину
            }

        }
        public static void Ex6()
        {

            string[] d1 = { "проституки!", "гады" };
            Ded ded1 = new Ded("Кузя", 1, d1, 0);
            string[] d2 = { "проститутки!", "гандоны", "пидорасы" };
            Ded ded2 = new Ded("Ибрагим", 2, d2, 0);
            string[] d3 = { "проституки!", "гады", "суки", "хуйло", "пошли вон" };
            Ded ded3 = new Ded("Яким", 3, d3, 0);
            string[] d4 = { "проституки!", "пидорасы" };
            Ded ded4 = new Ded("Константин", 1, d4, 0);
            string[] d5 = { "проституки!"};
            Ded ded5 = new Ded("Андрей", 4, d5, 0);
            string[] words = { "ебланы", "суки", "хуйло" };
            Console.WriteLine("Количество синяков Кузе от бабки: " + dedHits(ded1, words));
            Console.WriteLine("Количество синяков Ибрагиму от бабки: " + dedHits(ded2, words));
            Console.WriteLine("Количество синяков Якиму от бабки: " + dedHits(ded3, words));
            Console.WriteLine("Количество синяков Константину от бабки: " + dedHits(ded4, words));
            Console.WriteLine("Количество синяков Андрею от бабки: " + dedHits(ded5, words));

        }
        struct Ded
        {
            public string name;
            public byte levelofanger;
            public string[] phrases;
            public byte hits;
            public Ded(string Name, byte LvlAnger, string[] Phrases, byte Hits)
            {
                this.name = Name;
                this.levelofanger = LvlAnger;
                this.phrases = Phrases;
                this.hits = Hits;
            }
        }
        enum levelofanger
        {
            хороший=1,
            сердитый=2,
            ворчун=3,
            злой=4
        }
        static byte dedHits(Ded ded, params string[] array)
        {
            foreach (string i in ded.phrases)
            {
                if (array.Contains(i))
                {
                    ded.hits += 1;
                }
            }
            return ded.hits;
        }
        
        public static void Ex7()
        {
            int[] inputArray = { 9, 12, 55, 2, 17, 1, 6 };

            int[] sortedArray = QuickSort(inputArray, 0, inputArray.Length - 1);

            Console.WriteLine($"Sorted array: {string.Join(", ", sortedArray)}");

            Console.ReadLine();
        }

        private static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

            QuickSort(array, minIndex, pivotIndex - 1);

            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        private static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;

            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);

            return pivot;
        }

        private static void Swap(ref int leftItem, ref int rightItem)
        {
            int temp = leftItem;

            leftItem = rightItem;

            rightItem = temp;
        }
        public static void dolg1()
        {
            int[] numbers = new int[] { 97, 45, 32, 65, 83, 23, 15 };
            Array.Sort(numbers);
            foreach (int n in numbers)
                Console.WriteLine("Отсортированнный массив:" + n);
        }
        public static void dolg2()
        {
            
        }
    }

}
