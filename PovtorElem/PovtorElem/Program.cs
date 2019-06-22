﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemanT_Library;

namespace PovtorElem
{
    class Program
    {
        private static int n;
        private static int[] elements;
        private static void Request()
        {
            ColorMess.Yellow("\n Введите колличество элементов из скольки будем генерировать варианты (от 2 до 5): ");
            n = Input.Check(2, 10);
            elements = new int[n];
            for(int i = 0; i<n; i++)
            {
                Console.Clear();
                ColorMess.Yellow("\n Введите " + (i+1) + " число (от 0 до 9): ");
                elements[i] = Input.Check(0, 9);
            }
        }
        private static void PrintElements()
        {
            ColorMess.Cyan("\n Исходные элементы: ");
            for (int i = 0; i < n; i++)
                ColorMess.White(" " + elements[i]);
            Console.WriteLine();
        }
        static void Main()
        {
            Request();
            Console.WriteLine();
            PrintElements();
            Message.GoToBack();
        }
    }
}
