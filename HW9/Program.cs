string PrintNumRow(int start, int end)
{
   if (start == end) return start.ToString();
   return start + ", " + PrintNumRow(start + 1, end);
}
int SumNumRow(int start, int end)
{
   if (start == end) return start;
   return start + SumNumRow(start + 1, end);
}
int AckermanFunction(int m, int n)
{
   if (m == 0) return n + 1;
   if (n == 0 && m > 0) return AckermanFunction(m - 1, 1);
   else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

Console.WriteLine(PrintNumRow(4, 8));
Console.WriteLine(SumNumRow(1, 15));
Console.WriteLine(AckermanFunction(3, 2));