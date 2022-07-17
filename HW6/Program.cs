int InputArrayAndCountPositiveNumbers()
{
   int positiveNumbersCount = 0;
   Console.WriteLine("How many numbers will you type?");
   for (int i = 0; i < Convert.ToInt32(Console.ReadLine()); i++)
   {
      Console.WriteLine("Write numer");
      if (Convert.ToInt32(Console.ReadLine()) > 0) positiveNumbersCount++;
   }
   return positiveNumbersCount;

}

void PrintIntersectionPoint()
{
   Console.WriteLine("Enter b1, k1, b2, k2");
   double b1 = Convert.ToInt32(Console.ReadLine());
   double k1 = Convert.ToInt32(Console.ReadLine());
   double b2 = Convert.ToInt32(Console.ReadLine());
   double k2 = Convert.ToInt32(Console.ReadLine());
   double resultPointX = (b1 - b2) / ((k1 - k2) * -1);
   double resultPointY = k2 * resultPointX + b2;
   Console.WriteLine($"({resultPointX}; {resultPointY})");
}

Console.WriteLine(InputArrayAndCountPositiveNumbers());
PrintIntersectionPoint();