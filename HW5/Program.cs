
int CountEvenInArray()
{
   int[] array = new int[12];
   int size = array.Length;
   int result = 0;

   for (int i = 0; i < size; i++)
   {
      array[i] = new Random().Next(100, 1000);
      if (array[i] % 2 == 0) result++;
   }
   Console.WriteLine($"{String.Join("; ", array)}");
   return result;
}

int SumOddElementsInArray()
{
   int[] array = new int[12];
   int size = array.Length;
   int result = 0;

   for (int i = 0; i < size; i++)
   {
      array[i] = new Random().Next(-99, 100);
      if (i % 2 == 1) result += array[i];
   }
   Console.WriteLine($"{String.Join("; ", array)}");
   return result;
}


double DifferenceMaxAndMinInArray()
{
   double[] array = new double[12];
   int size = array.Length;
   double minNum = 100;
   double maxNum = 0;

   for (int i = 0; i < size; i++)
   {
      array[i] = new Random().NextDouble() * 100;
      if (array[i] > maxNum) maxNum = array[i];
      if (array[i] < minNum) minNum = array[i];
   }
   Console.WriteLine($"{String.Join("; ", array)}");
   return maxNum - minNum;
}


Console.WriteLine(CountEvenInArray());
Console.WriteLine(SumOddElementsInArray());
Console.WriteLine(DifferenceMaxAndMinInArray());