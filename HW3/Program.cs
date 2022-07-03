bool IsPalindrome(string word)
{
   int middle = (word.Count() - 1) / 2;
   for (int i = 0; i <= middle; i++) if (word[i] != word[word.Count() - 1 - i]) return false;
   return true;
}
double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
   return (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));
}
void PrintCubesRow(int num)
{
   for (int i = 1; i < num; i++)
   {
      Console.Write($"{Math.Pow(i, 3)}, ");
   }
   Console.WriteLine(Math.Pow(num, 3));
}

string word = Console.ReadLine();
if (word != null) Console.WriteLine(IsPalindrome(word));

Console.WriteLine(Math.Round(Distance(7, -5, 0, 1, -1, 9) * 100) / 100);

int num = Convert.ToInt32(Console.ReadLine());
PrintCubesRow(num);