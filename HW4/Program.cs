int MyPow(int num, int degree)
{
   int initialNum = num;
   if (num < 0) return 0;
   if (num == 0) return 1;
   for (int i = 1; i < degree; i++)
   {
      num *= initialNum;
   }
   return num;
}
int NumSum(int num)
{
   int result = 0;
   while (num > 0)
   {
      result += num % 10;
      num /= 10;
   }
   return result;
}
int[] NumArray(params int[] nums)
{
   // int[] numArray = new int[nums.Length]; 
   // for (int i = 0; i < nums.Length; i++)
   // {
   //    numArray[i] = nums[i];
   // }
   // return numArray;
   return nums;
}


Console.WriteLine(MyPow(3, 5));
Console.WriteLine(NumSum(1541));
Console.WriteLine($"{string.Join(", ", NumArray(3, 5, 10, 12))}");