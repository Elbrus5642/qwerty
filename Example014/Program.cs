// Двумерные массивы  
/* string [,] table = new string [2,5];
int [,] matrix = new int[5,8];

table[0,1] = "word";
table[1,3] = "hare";
// индексы меняются от 0 до n - 1  и по строкам и по столбцам
//string.Empty - инициализация строки
for (int rows = 0;  rows < 2; rows++)
{
    for (int cols = 0; cols < 5; cols++)
    {
        Console.Write($"-{table[rows,cols]}-");
         
    }
   Console.WriteLine();
}
*/
int [,] matrix = new int[3,4];
 for (int i = 0;  i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]} ");
         
    }
   Console.WriteLine();
}   
