int SecondNum(int a)
{
   return a / 10 % 10;
}
void PrintThirdNum(int a)
{
   if (a < 100) Console.WriteLine("No third number");
   else Console.WriteLine(a.ToString()[2]);
}
bool IsDayOff(int a)
{
   if (a > 7 || a < 6) return false;
   else return true;
}

Console.WriteLine(SecondNum(147));
PrintThirdNum(14857);
Console.WriteLine(IsDayOff(6));