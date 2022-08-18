// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


using static System.Console; 
Clear();

  int Sum(int N)
  {
    int count = Convert.ToString(N).Length;
    int var = 0;
    int result = 0;
        for (int i = 0; i < count; i++)
        {
          var = N - N % 10;
          result = result + (N - var);
          N = N / 10;
        }
        return result;
  }

Write("Введите число N: ");
int N = Convert.ToInt32(ReadLine());
int sum = Sum(N);
WriteLine("Сумма цифр в числе: " + sum);
