/*
Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.

Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, 
с каждым новым элементом увеличивающимся на опрделенное число. Метод принимает на вход три числа 
(n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент)
и возвращает матрицу, удовлетворяющую этим условиям.

Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив типа double.
Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.

Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns и
выводит этот список на экран в формате "The averages in columns are: x.x0 x.x0 x.x0 ...",
где x.x0 - это значения средних значений столбцов, округленные до двух знаков после запятой, разделенные знаком табуляции.
*/

int[,] arr = CreateIncreasingMatrix(3, 4, 2);
PrintArray(arr);
double[] arrRes = FindAverageInColumns(arr);
PrintListAvr(arrRes);

void PrintListAvr(double[] arrstr)
{
    System.Console.WriteLine("The averages in columns are:");
    for (int i = 0; i < arrstr.Length; i++)
    {
        System.Console.Write($"{string.Format("{0:f}", arrstr[i])}\t");
    }
}

double[] FindAverageInColumns(int[,] array)
{
    double[] resultArray = new double[array.GetLength(1)];
    int count = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            resultArray[i] = resultArray[i] + array[j, count];
        }
        count++;
        resultArray[i] = resultArray[i] / array.GetLength(0);
    }
    return resultArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    //Random random = new Random();
    int[,] array = new int[n, m];
    array[0, 0] = 1;//random.Next(0, 10);
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = array[0, 0] + sum;
            sum += k;
        }
    }
    return array;
}