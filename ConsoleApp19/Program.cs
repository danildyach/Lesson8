using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Вывод задачи номер 54 :");
            Console.Write("Строк:");
            int lin = Convert.ToInt32(Console.ReadLine());
            Console.Write("Столбцов:");
            int col = Convert.ToInt32(Console.ReadLine());
            zd54(lin, col);
            Console.WriteLine("Вывод задачи номер 56 (В не строки и столбцы не могут совпадать ):");
            Console.Write("Строк:");
            int linn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Столбцов:");
            int coll = Convert.ToInt32(Console.ReadLine());
            zd56(linn, coll);
            Console.WriteLine("Вывод задачи номер 58 :");
            Console.Write("Строк:");
            int linin = Convert.ToInt32(Console.ReadLine());
            Console.Write("Столбцов:");
            int colol = Convert.ToInt32(Console.ReadLine());
            zd58(linin, colol);
            Console.WriteLine("Вывод задачи 60 :");
            Console.Write("Строк:");
            int line = Convert.ToInt32(Console.ReadLine());
            Console.Write("Столбцов:");
            int post = Convert.ToInt32(Console.ReadLine());
            Console.Write("Высот:");
            int height = Convert.ToInt32(Console.ReadLine());
            zd60(line, post, height);
        }
        static void zd54(int lin, int col)
        {
            // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
            // по убыванию элементы каждой строки двумерного массива.
            // Например, задан массив:
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4
            // В итоге получается вот такой массив:
            // 7 4 2 1
            // 9 5 3 2
            // 8 4 4 2


            Console.WriteLine("Исходный массив:");
            int[,] array = new int[lin, col];
            Random rnd = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(10);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int[] lins = new int[array.GetLength(1)];
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    lins[j] = array[i, j];
                }
                WillSortTheElementsInDescendingOrder(ref lins);
                Insert(true, i, lins, array);
            }

            Console.WriteLine("Отсортированный массив:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void WillSortTheElementsInDescendingOrder(ref int[] lins)
        {
            for (int i = 0; i < lins.Length - 1; i++)
            {
                for (int j = 0; j < lins.Length - i - 1; j++)
                {
                    if (lins[j] < lins[j + 1])
                    {
                        int temp = lins[j];
                        lins[j] = lins[j + 1];
                        lins[j + 1] = temp;
                    }
                }
            }
        }

        static void Insert(bool isRow, int dim, int[] source, int[,] dest)
        {
            for (int k = 0; k < source.Length; k++)
            {
                if (isRow)
                    dest[dim, k] = source[k];
                else
                    dest[k, dim] = source[k];
            }
        }
        static void zd56(int linn, int coll)
        {
            //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
            //Например, задан массив:
            //1 4 7 2
            //5 9 2 3
            //8 4 2 4
            //5 2 6 7
            //Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
            if (linn == coll)
            {
                Console.WriteLine("Введены не верные данные");
            }
            else
            {

                int[,] array = new int[linn, coll];
                Random random = new Random();
                int summ = 0;
                Console.WriteLine("Исходный массив:");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = random.Next(10);
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("сумма строк :");
                SmallestSumOfElements(array, random);

            }
        }
        static void SmallestSumOfElements(int[,] array, Random random)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                    
                    
                }
                if (sum < min)
                {
                    min = sum;
                }

                Console.WriteLine(sum + " ");
            }
            Console.WriteLine($"Наименьшая сумма {min}");
        }
        static void zd58(int linin, int colol)
        {
            Random random = new Random();
            int[,] matrix1 = new int[linin, colol];
            int[,] matrix2 = new int[linin, colol];
            Console.WriteLine("Первая матрица");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(0); j++)
                {
                    matrix1[i, j] = random.Next(10);
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Вторая матрица");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(0); j++)
                {
                    matrix2[i, j] = random.Next(10);
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }

            int rowsMatrix1 = matrix1.GetLength(0);
            int colsMatrix1 = matrix1.GetLength(1);
            int rowsMatrix2 = matrix2.GetLength(0);
            int colsMatrix2 = matrix2.GetLength(1);

            if (colsMatrix1 != rowsMatrix2)
            {
                Console.WriteLine("Умножение матриц невозможно, так как количество столбцов первой матрицы не равно количеству строк второй матрицы.");
                return;
            }


            int[,] resultMatrix = new int[rowsMatrix1, colsMatrix2];


            for (int i = 0; i < rowsMatrix1; i++)
            {
                for (int j = 0; j < colsMatrix2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < colsMatrix1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    resultMatrix[i, j] = sum;
                }
            }


            Console.WriteLine("Результирующая матрица:");
            for (int i = 0; i < rowsMatrix1; i++)
            {
                for (int j = 0; j < colsMatrix2; j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void zd60(int line, int post, int height)
        {
            //Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
            //Массив размером 2 x 2 x 2
            //66(0, 0, 0) 25(0, 1, 0)
            //34(1, 0, 0) 41(1, 1, 0)
            //27(0, 0, 1) 90(0, 1, 1)
            //26(1, 0, 1) 55(1, 1, 1)
            Random random = new Random();
            int[,,] array = new int[line, post, height];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = random.Next(10, 100);
                        Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
                    }
                    Console.WriteLine();
                }
            }
        }



    }
}
