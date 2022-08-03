double[,] NewTwoDimensionalArray()
{
   int height = int.Parse(Console.ReadLine());
   int width = int.Parse(Console.ReadLine());
   double[,] array = new double[height, width];
   for (int i = 0; i < height; i++)
   {
      for (int j = 0; j < width; j++)
      {
         array[i, j] = Math.Round(new Random().NextDouble() * 1000) / 10;
         if (new Random().Next(0, 2) == 1) array[i, j] *= -1;
      }
   }
   return array;
}

void FindAndPrintNumInArray(double[,] array)
{
   int row = int.Parse(Console.ReadLine());
   int column = int.Parse(Console.ReadLine());
   if (row < array.GetLength(0) && row >= 0 || column < array.GetLength(1) && column >= 0)
      Console.WriteLine(array[row, column]);
   else Console.WriteLine("array out of bounds");
}

void PrintColumnAverageInArray(double[,] array)
{
   for (int i = 0; i < array.GetLength(1); i++)
   {
      double average = 0;
      for (int j = 0; j < array.GetLength(0); j++)
      {
         average += array[j, i];
      }
      average /= array.GetLength(0);
      Console.Write(Math.Round(average * 10) / 10 + " ");
   }
}

double[,] array = NewTwoDimensionalArray();
for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
      Console.Write(array[i, j] + " ");
   }
   Console.WriteLine();
}

FindAndPrintNumInArray(array);
PrintColumnAverageInArray(array);
