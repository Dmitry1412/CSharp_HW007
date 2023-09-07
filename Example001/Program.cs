/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n (размеренность массива),
а также minLimitRandom и maxLimitRandom, которые указывают на минимальную и максимальную границы случайных чисел.
Также, задайте метод PrintArray, который выводил бы массив на экран.
*/

double[,] arr = CreateRandomMatrix(4, 4, 1, 8);
PrintArray(arr);

double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    Random random = new Random();
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.NextDouble() * (maxLimitRandom - minLimitRandom) + minLimitRandom;
            array[i,j] = Math.Round(array[i,j], 2);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();  
    }
}