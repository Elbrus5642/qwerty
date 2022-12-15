//  Нарисован контур, необходимо закрасить  фигуру внутри этого контура
// Для начала необходимо инициализировать (задать) массив - в таком виде, как он выглядит на экране
int [,] pic = new int [23,25];
// 0 -  незактрашенный пиксель,  1  -  закрашенный пиксель
// Правило обхода точек внутри контура : сначала вверх -> влево -> вниз -> вправо
void ImagePrint(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i,j] == 0 ) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}
void FillImage(int row, int col)
// Функции передаётся начальная точка закраски, т.е. откуда начинается закраска
{
  if (pic(row, col) == 0)
  {
    pic(row,col) = 1;
    FillImage(row-1, col);
    FillImage(row, col-1);
    FillImage(row+1, col);
    FillImage(row , col+1);
  }
}

ImagePrint(pic);
FillImage(13,13);
ImagePrint(pic);