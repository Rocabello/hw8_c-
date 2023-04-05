// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
int str = UserData("Введите кол-во строк");
int column = UserData("Введите кол-во столбцов массива: ");
int[,] array = (GetArray(str, column, 10, 20));
PrintArray(array);
System.Console.WriteLine("Массив по убыванию: ");
PrintArray(Task(array, str, column));

// ----------Сортировка по убыванию
int[,] Task(int[,] array, int str, int column)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            int maxPosition = i;
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[k, j] > array[k, maxPosition]) maxPosition = j;
            }
            int temporary = array[k, i];
            array[k, i] = array[k, maxPosition];
            array[k, maxPosition] = temporary;
        }
    }
    return array;
}

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
}

// ----------------Опрос пользователя по массиву
int UserData(string message)
{
    System.Console.WriteLine($"{message}");
    return int.Parse(Console.ReadLine());
}