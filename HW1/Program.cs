int maxOfTwo(int a, int b)
{
   if (a > b) return a;
   else return b;
}
int maxOfThree(int a, int b, int c)
{
   if (a > b)
   {
      if (a > c) return a;
      else return c;
   }
   else if (b > c)
   {
      if (b > a) return b;
      else return a;
   }
   else
   {
      if (c > a) return c;
      else return b;
   }
}
bool IsEven(int a)
{
   if (a % 2 == 0) return true;
   else return false;
}
void PrintEvenRow(int a)
{
   int even = 2;
   while (even <= a - 2)
   {
      Console.Write($"{even}, ");
      even += 2;
   }
   Console.Write($"{even}");
}

Console.WriteLine(maxOfTwo(10, 1));
Console.WriteLine(maxOfThree(10, 1, 5));
Console.WriteLine(IsEven(-2));
PrintEvenRow(15);
