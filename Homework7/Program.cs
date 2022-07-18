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

// int[,] array = new int[m, n];

// CreateArrayint(array);

// WriteArray(array);

// Console.WriteLine();

// void CreateArrayint(int[,] array)
// {
//   for (int i = 0; i < m; i++)
//   {
//     for (int j = 0; j < n; j++)
//     {
//       array[i, j] = new Random().Nextint() * 20 - 10;
//     }
//   }
// }

// void WriteArray (int[,] array){
// for (int i = 0; i < m; i++)
//   {
//       for (int j = 0; j < n; j++)
//       {
//         int alignNumber = Math.Round(array[i, j], 1);
//         Console.Write(alignNumber + " ");
//       }
//       Console.WriteLine();
//   }
// }









// Console.Clear();

// int[,] GetArray(int m, int n, int minValue, int maxValue) // создает двумерный массив
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
// void PrintArray(int[,] inArray) // вывводит двумерный массив
// {
// for (int row = 0; row < inArray.GetLength(0); row++)
// {
// for (int column = 0; column < inArray.GetLength(1); column++)
// {
// Console.Write($"{inArray[row,column]} ");
// }
// Console.WriteLine();
// }
// }

// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);


// Console.Write("Введите индекс строки массива: ");
// int m =Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите индекс столбца массива: ");
// int n =Convert.ToInt32(Console.ReadLine());

// Console.Write($"{m}-{n}");

// if (m < array.GetLength(0) && n < array.GetLength(1)){
//     Console.WriteLine (" -> такое число есть ");
// }
// else{
//     Console.WriteLine (" -> такого числа нет ");
    
// }
