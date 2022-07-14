// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



// Console.Clear();

// Console.WriteLine($"Задача 41. Cколько чисел больше 0 ввёл пользователь \n");
// Console.Write($"Введи число М(количество чисел): ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] massiveNumbers = new int[m];

// void InputNumbers(int m){
// for (int i = 0; i < m; i++)
//   {
//     Console.Write($"Введи {i+1} число: ");
//     massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
//   }
// }


// int Comparison(int[] massiveNumbers)
// {
//   int count = 0;
//   for (int i = 0; i < massiveNumbers.Length; i++)
//   {
//     if(massiveNumbers[i] > 0 ) count += 1; 
//   }
//   return count;
// }

// InputNumbers(m);

// Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");




// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



// Console.Clear();
// Console.WriteLine("Введите значения k1 и b1 для прямой, заданной уравнением y = k1 * x + b1:");
// Console.Write("k1 = ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("b1 = ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите значения k2 и b2 для прямой, заданной уравнением y = k2 * x + b2:");
// Console.Write("k2 = ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("b2 = ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// if (k1 == k2){
//    if (b1 == b2){
//      Console.WriteLine("\nТочек пересечения бесконечно много - прямые совпадают.\n");
//    }
//    else{
//         Console.WriteLine("\nТочек пересечения нет - прямые параллельны.\n");
//    }
// }
// else{
//      Console.WriteLine("\nКоординаты точки пересечения двух прямых при заданных значениях:\n");
//      double x = (b1 - b2)/(k2 - k1);
//      double y = k1 * x + b1;
//      Console.WriteLine($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} -> ({x}; {y})\n");
// }