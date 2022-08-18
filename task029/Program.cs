// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


using static System.Console; 
Clear();

//int [] numbers = new int[8];
//Console.Write("[");
//    for (int i = 0; i < numbers.Length; i++)
//        {
//         numbers [i] = new Random().Next();
//        Console.Write(" " + Method (i) + " ");
//       }
//    Console.Write("]");



//int Method (int a)
//{
//    return numbers[a];
//}


int [] NewArray = GetArrey(8);
PrintArray(NewArray);
WriteLine();



int [] GetArrey (int N)
{
int [] array = new int[N];
for (int i = 0;  i<N; i++)
    {
       array [i]= new Random().Next ();  
    }
       return array;
       }

void PrintArray(int[] Mass)
{
    Write("[ ");
    for (int i = 0;  i<Mass.Length; i++)
    {
      Write (Mass[i] + ", ");
    }
    Write("]");
}
