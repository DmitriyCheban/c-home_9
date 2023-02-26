/* Из двумерного массива целых чисел удалить строку и столбец,
на пересечении которых расположен первый найденный наименьший элемент. */


Console.Clear();

int m = InputNumbers("Введите количество строк: ");
int n = InputNumbers("Введите количество столбцов: ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int[,] MinElement = new int[1, 2];
MinElement = MinElementPosition(array, MinElement);
Console.Write("Позиция элемента:" );
WriteArray(MinElement);

int[,] arrayLine = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
Lines(array, MinElement, arrayLine);
Console.WriteLine("Получившийся массив:");
WriteArray(arrayLine);


int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,10);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

int[,] MinElementPosition(int[,] array, int[,] position)
{
  int temp = array[0, 0];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] <= temp)
      {
        position[0, 0] = i;
        position[0, 1] = j;
        temp = array[i, j];
      }
    }
  }
  Console.WriteLine($"Mинимальный элемент: {temp}");
  return position;
}

void Lines(int[,] array, int[,] MinElement, int[,] arrayLine)
{
  int k = 0, l = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (MinElement[0, 0] != i && MinElement[0, 1] != j)
      {
        arrayLine[k, l] = array[i, j];
        l++;
      }
    }
    l = 0;
    if (MinElement[0, 0] != i)
    {
      k++;
    }
  }
}