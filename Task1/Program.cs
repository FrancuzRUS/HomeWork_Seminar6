// Показать двумерный массив размером m×n заполненный вещественными числами
Console.WriteLine("Введите размерность массива");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
double [,] array = new double[m,n];
  
for (int i=0; i<m; i++)
   { Console.WriteLine();
   for (int j = 0; j<n; j++)
        {   array[i,j]=(i+0.1)/(j+0.2);
            Console.Write($"   {array[i,j]}");
        }
   }

