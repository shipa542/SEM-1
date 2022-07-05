// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


{
            Console.Write("Введите число :");
            string num = Console.ReadLine();
            int len = num.Length;
            bool flag = true;
 
        
            for (int i = 0; i < len/2; i++)
            {
                if (num[i] != num[len - (i + 1)])
                {
                    flag = false;
                    break;
                }
            }
 
            
            if (flag)
            {
                Console.WriteLine("Палиндром");
            }
            else
            {
                Console.WriteLine("Не палиндром");
            }
            Console.ReadLine();
        }


