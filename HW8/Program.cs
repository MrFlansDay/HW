int[,] NewMatrix(int height, int width, int rangeStart, int rangeEnd, bool printMatrix = false)
{
   int[,] matrix = new int[height, width];
   for (int i = 0; i < height; i++)
   {
      for (int j = 0; j < width; j++)
      {
         matrix[i, j] = new Random().Next(rangeStart, rangeEnd + 1);
      }
   }
   if (printMatrix) PrintMatrix(matrix);
   return matrix;
}
void PrintMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         Console.Write(matrix[i, j] + " ");
      }
      Console.WriteLine();
   }
   Console.WriteLine();
}
void SortRowsInMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         int minInt = int.MaxValue;
         int maxIntColumn = 0;
         for (int k = j; k < matrix.GetLength(1); k++)
         {
            if (minInt > matrix[i, k])
            {
               minInt = matrix[i, k];
               maxIntColumn = k;
            }
         }
         int temp = matrix[i, j];
         matrix[i, j] = minInt;
         matrix[i, maxIntColumn] = temp;
      }
   }
}

int FindRowWithMinNumber(int[,] matrix)
{
   int rowWithMinNum = 0;
   int minNum = int.MaxValue;
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         if (matrix[i, j] < minNum)
         {
            minNum = matrix[i, j];
            rowWithMinNum = i;
         }
      }
   }
   return rowWithMinNum;
}
int[,] MatrixsProduct(int[,] matrix1, int[,] matrix2, bool printMatrix = false)
{
   int height = matrix1.GetLength(0);
   int width = matrix1.GetLength(1);
   int[,] matrixsProduct = new int[height, width];
   if (height != matrix2.GetLength(0) || width != matrix2.GetLength(1)) return matrixsProduct;
   for (int i = 0; i < height; i++)
   {
      for (int j = 0; j < width; j++)
      {
         matrixsProduct[i, j] = matrix1[i, j] * matrix2[i, j];
      }
   }
   if (printMatrix) PrintMatrix(matrixsProduct);
   return matrixsProduct;
}
void MatrixSpiralFill(int[,] matrix, bool printMatrix = false)
{
   int height = matrix.GetLength(0);
   int width = matrix.GetLength(1);
   if (height != width) return;
   int NumberOfInnerSquares = height - 2;
   int counter = 1;
   int rangeStart = 0;
   int rangeEnd = width;
   for (int i = 0; i <= NumberOfInnerSquares; i++)
   {
      FillBorderMatrix(matrix, rangeStart, rangeEnd, ref counter);
      rangeStart++;
      rangeEnd--;
   }
   if (width == 1) matrix[0, 0] = counter;
   if (printMatrix) PrintMatrix(matrix);
}
void FillBorderMatrix(int[,] matrix, int rangeStart, int rangeEnd, ref int startNum)
{
   for (int j = rangeStart; j < rangeEnd; j++)
   {
      matrix[rangeStart, j] = startNum;
      startNum++;
   }
   for (int j = rangeStart + 1; j < rangeEnd; j++)
   {
      matrix[j, rangeEnd - 1] = startNum;
      startNum++;
   }
   for (int j = rangeEnd - 2; j >= rangeStart; j--)
   {
      matrix[rangeEnd - 1, j] = startNum;
      startNum++;
   }
   for (int j = rangeEnd - 2; j > rangeStart; j--)
   {
      matrix[j, rangeStart] = startNum;
      startNum++;
   }
}

int[,] matrix = NewMatrix(4, 4, 10, 100, true);

SortRowsInMatrix(matrix);
PrintMatrix(matrix);

Console.WriteLine(FindRowWithMinNumber(matrix));

int[,] matrix1 = NewMatrix(4, 4, 0, 10, true);
int[,] matrix2 = NewMatrix(4, 4, 0, 10, true);
MatrixsProduct(matrix1, matrix2, true);

MatrixSpiralFill(matrix, true);