// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using static System.Console; 
Clear();

Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = 1;
   for(int i=1; i <= B; i++)
    {
    result = result*A;
    }
WriteLine("Число A в натуральной степень B = " + result);



//Write("Введите число A: ");
//int A = Convert.ToInt32(Console.ReadLine());
//Write("Введите число B: ");
//int B = Convert.ToInt32(Console.ReadLine());
//WriteLine("Число A в натуральной степень B = " + Math.Pow(A, B));