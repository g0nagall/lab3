using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_lab3
{
	class Program
	{
		//ЗАВДАННЯ
		//static void Main()
		//{
		//    int[] myArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		//    int i;
		//    for (i = 0; i < 10; ++i)
		//        Console.Write(myArray[i]);
		//}

		//ЗАВДАННЯ
		//static void Main()
		//{
		//    int n = 10;
		//    int[] myArray = new int[n];
		//    int i;
		//    for (i = 0; i < n; i++)
		//        myArray[i] = i * i;
		//    for (i = 0; i < n; i++)
		//        Console.WriteLine(myArray[i]);
		//}

		//ЗАВДАННЯ
		//static void Main()
		//{
		//    int[] myArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		//    int i;
		//    try
		//    {
		//        for (i = 0; i <= 10; i++) Console.WriteLine(myArray[i]);
		//    }
		//    catch (IndexOutOfRangeException)
		//    {
		//        Console.WriteLine("Exception: Вихід за межі діапазону");
		//    }
		//    catch (OverflowException)
		//    {
		//        Console.WriteLine("переповнення");
		//    }
		//    catch (OutOfMemoryException)
		//    {
		//        Console.WriteLine("недостатньо пам'яті для створення нового об'єкта");
		//    }
		//}

		//ЗАВДАННЯ
		//static void InputArray(int[,] mas)
		//{
		//    for (int i = 0; i < mas.GetLength(0); i++)
		//    {
		//        for (int j = 0; j < mas.GetLength(1); j++)
		//            mas[i, j] = Convert.ToInt32(Console.ReadLine());
		//    }
		//}
		//static void PrintArray(string a, int[,] mas)
		//{
		//    Console.WriteLine(a);
		//    for (int i = 0; i < mas.GetLength(0); i++)
		//    {
		//        for (int j = 0; j < mas.GetLength(1); j++)
		//            Console.Write("{0} ", mas[i, j]);
		//        Console.WriteLine();
		//    }
		//}
		//static int Change(int[,] mas)
		//{
		//    int sum = 0;
		//    for (int i = 0; i < mas.GetLength(0); i++)
		//        for (int j = 0; j < mas.GetLength(1); j++)
		//            if (mas[i, j] % 2 == 0)
		//                sum += mas[i, j];
		//    return sum;
		//}
		//static void Main()
		//{
		//    try
		//    {
		//        int[,] MyArray = new int[3, 3];
		//        InputArray(MyArray);
		//        PrintArray("вихідний масив:", MyArray);
		//        Console.WriteLine("\n Sum = " + Change(MyArray));
		//    }
		//    catch (FormatException)
		//    {
		//        Console.WriteLine("невірний формат вводу даних");
		//    }
		//    catch (OverflowException)
		//    {
		//        Console.WriteLine("переповнення");
		//    }
		//    catch (OutOfMemoryException)
		//    {
		//        Console.WriteLine("недостатньо пам'яті для створення нового об'єкта");
		//    }

		//}

		//ЗАВДАННЯ
		//static void Main()
		//{
		//    try
		//    {
		//        int[][] MyArray;
		//        Console.Write("Уведіть кількість рядків: ");
		//        int n = int.Parse(Console.ReadLine());
		//        MyArray = new int[n][];
		//        for (int i = 0; i < MyArray.Length; i++)
		//        {
		//            Console.Write("введіть кількість елементів в {0} рядку: ", i);
		//            int j = int.Parse(Console.ReadLine());
		//            MyArray[i] = new int[j];
		//            for (j = 0; j < MyArray[i].Length; j++)
		//            {
		//                Console.Write("a[{0}][{1}]= ", i, j);
		//                MyArray[i][j] = int.Parse(Console.ReadLine());
		//            }
		//        }
		//        PrintArray("вихідний масив:", MyArray);
		//        for (int i = 0; i < MyArray.Length; i++) Array.Sort(MyArray[i]);
		//        PrintArray("змінений масив", MyArray);
		//        int[][] Arr;
		//        Console.Write("Уведіть кількість рядків: ");
		//        int N = int.Parse(Console.ReadLine());
		//        Arr = new int[N][];
		//        MakeArray(Arr);
		//        PrintArray("Array: ", Arr);

		//    }
		//    catch (FormatException)
		//    {
		//        Console.WriteLine("невірний формат вводу даних");
		//    }
		//    catch (OverflowException)
		//    {
		//        Console.WriteLine("переповнення");
		//    }
		//    catch (OutOfMemoryException)
		//    {
		//        Console.WriteLine("недостатньо пам'яті для створення нового об'єкта");
		//    }
		//}
		//static void PrintArray(string a, int[][] mas)
		//{
		//    Console.WriteLine(a);
		//    for (int i = 0; i < mas.Length; i++)
		//    {
		//        for (int j = 0; j < mas[i].Length; j++) Console.Write("{0} ",
		//        mas[i][j]);
		//        Console.WriteLine();
		//    }
		//}
		//static void MakeArray(int[][] mas)
		//{
		//    for (int i = 0; i < mas.Length; i++)
		//    {
		//        int j = i * 2;
		//        mas[i] = new int[j];
		//        for (j = 0; j < mas[i].Length; j++)
		//            mas[i][j] = i + j;
		//    }

		//}

		//ЗАВДАННЯ
		//static int[] Input()
		//{
		//    Console.WriteLine("введіть розмірність масиву");
		//    int n = int.Parse(Console.ReadLine());
		//    int[] a = new int[n];
		//    for (int i = 0; i < n; ++i)
		//    {
		//        Console.Write("a[{0}]= ", i);
		//        a[i] = int.Parse(Console.ReadLine());
		//    }
		//    return a;
		//}
		//static void Print(int[] a, int n)
		//{
		//    for (int i = 0; i < n; ++i) Console.Write("{0} ", a[i]);
		//    Console.WriteLine();
		//}
		//static void DeleteArray(int[] a, ref int n, int m)
		//{
		//    for (int i = m; i < n - 1; ++i)
		//        a[i] = a[i + 1];
		//    --n;
		//}
		//static void Main()
		//{
		//    try
		//    {
		//        int[] myArray = Input();
		//        int n = myArray.Length;
		//        Console.WriteLine("Вихідний масив:");
		//        Print(myArray, n);
		//        Console.WriteLine("Введіть номер елемента для видалення:");
		//        int m = int.Parse(Console.ReadLine());
		//        DeleteArray(myArray, ref n, m);
		//        Console.WriteLine("змінений масив:");
		//        Print(myArray, n);
		//    }

		//    catch (IndexOutOfRangeException)
		//    {
		//        Console.WriteLine("Вихід за межі діапазону");
		//    }

		//    catch (OutOfMemoryException)
		//    {
		//        Console.WriteLine("недостатньо пам'яті для створення нового об'єкта");
		//    }

		//}

		//ЗАВДАННЯ
		//static int[,] Input(out int n, out int m)
		//{
		//    Console.WriteLine("введіть розмірність масиву");
		//    Console.Write("n = ");
		//    n = int.Parse(Console.ReadLine());
		//    Console.Write("m = ");
		//    m = int.Parse(Console.ReadLine());
		//    int[,] a = new int[n, m];
		//    for (int i = 0; i < n; ++i)
		//        for (int j = 0; j < m; ++j)
		//        {
		//            Console.Write("a[{0},{1}]= ", i, j);
		//            a[i, j] = int.Parse(Console.ReadLine());
		//        }
		//    return a;
		//}
		//static void Print(int[,] a, int n, int m)
		//{
		//    for (int i = 0; i < n; ++i, Console.WriteLine())
		//        for (int j = 0; j < m; ++j)
		//            Console.Write("{0,5} ", a[i, j]);
		//}
		//static void DeleteArray(int[,] a, ref int n, ref int m, int k)
		//{
		//    for (int i = 0; i < n; ++i)
		//    {
		//        for (int j = k; j < m - 1; ++j)
		//            a[i, j] = a[i, j + 1];

		//    }
		//    --m;

		//}
		//static void Main()
		//{
		//    int n, m;
		//    int[,] myArray = Input(out n, out m);
		//    Console.WriteLine("Вихідний масив:");
		//    Print(myArray, n, m);
		//    Console.WriteLine("Введіть номер рядка для видалення:");
		//    int k = int.Parse(Console.ReadLine());
		//    DeleteArray(myArray, ref n, ref m, k);
		//    Console.WriteLine("змінений масив:");
		//    Print(myArray, n, m);
		//}

		//ЗАВДАННЯ 
		//static int[] Input()
		//{
		//    Console.WriteLine("введіть розмірність масиву ");
		//    int n = int.Parse(Console.ReadLine());
		//    int[] a = new int[n];
		//    for (int i = 0; i < n; ++i)
		//    {
		//        Console.Write("a[{0}]= ", i);
		//        a[i] = int.Parse(Console.ReadLine());
		//    }
		//    return a;
		//}
		//static int Max(int[] a)
		//{
		//    int max = a[0];
		//    for (int i = 1; i < a.Length; i++)
		//        if (a[i] > max) max = a[i];
		//    return max;
		//}
		//static int FirstMax(int[] a)
		//{
		//    index = 0;
		//    int max = a[0];
		//    for (int i = 1; i < a.Length; i++)
		//    {
		//        if (a[i] > max)
		//        {
		//            max = a[i];
		//            index = i;
		//            break;
		//        }

		//    }
		//    return index;
		//}
		//static int FirstMin(int[] a)
		//{
		//    int index = 0;
		//    int min = a[0];
		//    for (int i = 1; i < a.Length; i++)
		//        if (a[i] < min || a[i] == min)
		//        {
		//            min = a[i];
		//            index = i;
		//        }
		//    return index;
		//}

		//static int PositiveMin(int[] a)
		//{
		//    int min = 999999999;



		//    for (int i = 0; i < a.Length; i++)
		//    {
		//        if (a[i] > 0 && a[i] < min)
		//            min = a[i];
		//    }



		//    return min;
		//}
		//static void Main()
		//{
		//    int[] myArray = Input();
		//    int max = Max(myArray);
		//    int firstmax = FirstMax(myArray);
		//    int firstmin = FirstMin(myArray);
		//    int positivemin = PositiveMin(myArray);
		//    int kol = 0;
		//    for (int i = 0; i < myArray.Length; ++i)
		//        if (myArray[i] == max) ++kol;
		//    Console.WriteLine("Кількість максимальних елементів = " + kol);
		//    int sum = 0;
		//    for (int i = firstmax + 1; i < firstmin; i++)
		//        sum += myArray[i];
		//    Console.WriteLine("Сума між першим максимальним і останнім мінімальіним = " + sum);
		//    Console.WriteLine("Мінімальний позитивний елемент = " + positivemin);
		//}

		//ЗАВДАННЯ 
		static int[,] Input(out int n, out int m)
		{
			Console.WriteLine("введіть розмірність масиву");
			Console.Write("n = ");
			n = int.Parse(Console.ReadLine());
			Console.Write("m = ");
			m = int.Parse(Console.ReadLine());
			int[,] a = new int[n, m];
			for (int i = 0; i < n; ++i)
				for (int j = 0; j < m; ++j)
				{
					Console.Write("a[{0},{1}]= ", i, j);
					a[i, j] = int.Parse(Console.ReadLine());
				}
			return a;
		}
		static void Print(int[,] a, int n, int m)
		{
			for (int i = 0; i < n; ++i, Console.WriteLine())
				for (int j = 0; j < m; ++j)
					Console.Write("{0,5} ", a[i, j]);
		}
		static int AverageMainArr(int[,] a, int n, int m)
		{
			int average = 0, counter = 0, sum = 0;
			for (int i = 0; i < n; i++)
			{
				for (int j = i + 1; j < m; j++)
				{
					sum += a[i, j];
					counter++;
				}
			}
			average = sum / counter;
			return average;
		}

		static int AverageSideArr(int[,] a, int n, int m)
		{
			int average = 0, counter = 0, sum = 0;
			for (int i = 1; i < n; i++)
			{
				for (int j = n - i; j < n; j++)
				{
					sum += a[i, j];
					counter++;
				}
			}
			average = sum / counter;
			return average;
		}
		static void Main()
		{
			int n, m;
			int[,] myArray = Input(out n, out m);
			Console.WriteLine("Вихідний масив:");
			Print(myArray, n, m);
			int averageMain = AverageMainArr(myArray, n, m);
			int averageSide = AverageSideArr(myArray, n, m);
			Console.WriteLine("Сума елементів над головною діагоналлю: " + averageMain);
			Console.WriteLine("Сума елементів під побічною діагоналлю: " + averageSide);
		}



	}
}
