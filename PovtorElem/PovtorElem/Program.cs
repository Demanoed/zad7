using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemanT_Library;

namespace PovtorElem
{
    class Program
    {
        private static int n, k;
        private static int[] elements;
        private static void Request()
        {
            ColorMess.Yellow("\n Введите колличество элементов из скольки будем генерировать варианты (от 2 до 9): ");
            n = Input.Check(2, 9);
            ColorMess.Yellow("\n Сколько будет чисел (от 2 до 9): ");
            k = Input.Check(2, 9);
        }
        private static void PrintElements()
        {
            for (int i = 0; i < n; i++)
                ColorMess.White(" " + elements[i]);
            Console.WriteLine();
        }
        private static int Factorial(int number)
        {
            int res = 1;
            for (int i = number; i > 1; i--)
                res *= i;
            return res;
        }
        private static int KolvoChisel()
        {
            return (Factorial(k+n-1)) / (Factorial(n-1)*Factorial(k));
        }
        private static void GenerateElements()
        {
            elements = new int[n];
            int num = KolvoChisel();
            for (int i = 0; i < num; i++)
            {
                PrintElements();
                if (elements[n-1] != (k - 1))
                {
                    elements[n-1]++;
                }
                else
                {
                    for (int j = n - 1; j > 0; j--)
                    {
                        if (elements[j - 1] != (k - 1))
                        {
                            elements[j - 1]++;
                            for (int z = n - 1; z > j - 1; z--)
                                elements[z] = elements[j-1];
                            break;
                        }
                    }
                }
            }
        }
        static void Main()
        {
            Request();
            Console.WriteLine();
            ColorMess.Cyan("\n Результат:\n");
            GenerateElements();
            Message.GoToBack();
        }
    }
}
