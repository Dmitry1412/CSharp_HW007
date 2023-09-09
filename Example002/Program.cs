/*
Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.

Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности,
с каждым новым элементом увеличивающимся на опрделенное число. Метод принимает на вход три числа
(n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент)
и возвращает матрицу, удовлетворяющую этим условиям.

Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

Метод FindNumberByPosition принимает на вход сгенрированную матрицу и числа x и y - позиции элемента в матрице.
Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением.
Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в указанной позиции,
а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.

Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - позиции элемента в матрице.
Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), используя результаты
из метода FindNumberByPosition. Если такого элемента нет, вывести на экран "There is no such index".
Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".
*/
/*
ВНИМАНИЕ!!!!!
в автотестах проверка идет не по правилам нумерации позиции элементов массива, т.е.
для элемента массива с индексом (2,2), автотест посчитает корректным элемент с индексом (1, 1) = 6
1   2   3   4
5   6   7   8
9   10  11  12
в связи с этим осуществлены корректировки x-1 и y-1 в методах
*/

int[,] arr = CreateIncreasingMatrix(4, 4, 2);
PrintArray(arr);
int[,] arrResult = FindNumberByPosition(arr, 4, 4);
System.Console.WriteLine();
PrintArray(arrResult);
PrintCheckIfError(arrResult, 4, 4);

int[,] FindNumberByPosition(int[,] array, int x, int y)
{
    if (x > (array.GetLength(0)) | y > (array.GetLength(1)))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = 0;
            }
        } 
    }
    else
    {
        int tmp = array[x-1, y-1];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
               array[i, j] = 0;
               array[x-1,y-1] = tmp;
            }
        }  
    }
    return array;
}

void PrintCheckIfError(int[,] array, int x, int y)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
    }
    if (sum == 0) System.Console.WriteLine("There is no such index");
    else System.Console.WriteLine($"The number in [{x}, {y}] is {array[x-1, y-1]}");
}

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    Random random = new Random();
    int[,] array = new int[n, m];
    array[0, 0] = random.Next(0, 10);
    int sum = k;
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

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
    Console.WriteLine();  
    }
}