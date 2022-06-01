// Задать двумерный массив следующим правилом: Aₘₙ = m+n
Console.WriteLine("Введите размерность массива");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int [,] array = new int[m,n];
  
for (int i=0; i<m; i++)
  { Console.WriteLine();
     for (int j = 0; j<n; j++)
        {   array[i,j]=i+j;
            Console.Write($"  {array[i,j]}");
        }
  }
