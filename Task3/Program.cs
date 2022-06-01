// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

Console.WriteLine("Введите размерность массива");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int [,] array = new int[m,n];
Random r = new Random();

for (int i=0; i<m; i++)
{  Console.WriteLine();
    for (int j = 0; j<n; j++)
        {array[i, j] = r.Next(10);
     Console.Write($" {array[i,j]}");   
        }
}


for (int i=0; i<m; i++)
  {   Console.WriteLine();
  for (int j = 0; j<n; j++)
        {
        if (i % 2 == 0 && j % 2 == 0)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
        Console.Write($"  {array[i,j]}");   
        }
  }
