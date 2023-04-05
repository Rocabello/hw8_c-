// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int[,] array1 = (GetArray(2, 2, 1, 9));
UserData("Первая матрица: ");
PrintArray(array1);
int[,] array2 = (GetArray(2, 2, 1, 9));
UserData("Вторая матрица: ");
PrintArray(array2);

int[,] resArray = new int[2, 2];
ResMatrix(array1, array2);

System.Console.WriteLine("Результат:");
PrintArray(resArray);



// ----------------Заполнение массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

// -----------------Вывод массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} | ");
        }
        Console.WriteLine();

    }
    System.Console.WriteLine();
}

// ------------перемножение матриц

void ResMatrix(int[,] FirstArray, int[,] SecondArray)

{
    if (array1.GetLength(0) != array2.GetLength(1)) System.Console.WriteLine("Ошибка!");
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                resArray[i, j] = 0;
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    resArray[i, j] += array1[i, k] * array2[k, j];
                }

            }
        }

    }
}

// ----------------Сообщение
void UserData(string message)
{
    System.Console.WriteLine($"{message}");

}