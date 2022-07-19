// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9




// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Clear();
// Console.WriteLine($"m = {m}, n = {n}.");

// int[,] arrayay = new int[m, n];

// CreateArrayayint(arrayay);

// WriteArrayay(arrayay);

// Console.WriteLine();

// void CreateArrayayint(int[,] arrayay)
// {
//   for (int i = 0; i < m; i++)
//   {
//     for (int j = 0; j < n; j++)
//     {
//       arrayay[i, j] = new Random().Nextint() * 20 - 10;
//     }
//   }
// }

// void WriteArrayay (int[,] arrayay){
// for (int i = 0; i < m; i++)
//   {
//       for (int j = 0; j < n; j++)
//       {
//         int alignNumber = Math.Round(arrayay[i, j], 1);
//         Console.Write(alignNumber + " ");
//       }
//       Console.WriteLine();
//   }
// }



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4





// Console.Clear();

// int[,] GetArrayay(int m, int n, int minValue, int maxValue) // создает двумерный массив
// {
// int[,] result = new int[m, n];
// for (int i = 0; i < m; i++)
// {
// for (int j = 0; j < n; j++)
// {
// result[i, j] = new Random().Next(minValue, maxValue + 1);
// }
// }
// return result;

// }
// void PrintArrayay(int[,] inArrayay) // вывводит двумерный массив
// {
// for (int row = 0; row < inArrayay.GetLength(0); row++)
// {
// for (int column = 0; column < inArrayay.GetLength(1); column++)
// {
// Console.Write($"{inArrayay[row,column]} ");
// }
// Console.WriteLine();
// }
// }

// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] arrayay = GetArrayay(rows, columns, 0, 10);
// PrintArrayay(arrayay);


// Console.Write("Введите индекс строки массива: ");
// int m =Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите индекс столбца массива: ");
// int n =Convert.ToInt32(Console.ReadLine());

// Console.Write($"{m}-{n}");

// if (m < arrayay.GetLength(0) && n < arrayay.GetLength(1)){
//     Console.WriteLine (" -> такое число есть ");
// }
// else{
//     Console.WriteLine (" -> такого числа нет ");
    
// }




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



// Random random = new Random();
// int[,] array = new int[random.Next(1, 10), random.Next(1, 10)];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = random.Next(1, 10);
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("---------------------------");

// for (int j = 0; j < array.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum += array[i, j];
//     }
//     Console.WriteLine($"Среднее арифметическое столбца: { sum / array.GetLength(0):f1} ");
// }
// Console.WriteLine();