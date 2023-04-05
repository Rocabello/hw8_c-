// Задача 60. ...
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
// int str = UserData("Введите кол-во строк: ");
// int column = UserData("Введите кол-во столбцов массива: ");
// int deep = UserData("Введите глубину массива: ");
int[,,] array = (GetArray(2, 2, 2, 10, 99));
PrintArray(array);



// ----------------Опрос пользователя по массиву
int UserData(string message)
{
    System.Console.WriteLine($"{message}");
    return int.Parse(Console.ReadLine());
}
// ----------------Заполнение массива
int[,,] GetArray(int m, int n, int k, int minValue, int maxValue)
{

    int[,,] res = new int[m, n, k];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int g = 0; g < k; g++)
                res[i, j, g] = new Random().Next(minValue, maxValue + 1);


        }
    }
    return res;
}

// -----------------Вывод массива
void PrintArray(int[,,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int g = 0; g < array.GetLength(2); g++)
            {
                Console.Write($"{array[i, j, g]} ({i}, {j}, {g}); ");
            }
            Console.WriteLine();
        }
    }
}