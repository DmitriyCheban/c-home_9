//Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника.

Console.WriteLine("Введите количество строк треугольника Паскаля:");
int num = int.Parse(Console.ReadLine());


int [,] FillArray (int num)
{
    int line = num;
    int columns = num+1;
    int [,] array = new int [line, columns];

    for (int i = 1; i < array.GetLength(0); i++)
    {
            array[0, 0] = 0;
            array[0, 1] = 1;
            array[0, 2] = 0;
            
        for (int j = 1; j < array.GetLength(1); j++)
        {
            array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
        }
    }
    return array;
}



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int k = array.GetLength(0); k > i; k--)
            {
                Console.Write("  ");
            }
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0,4}", array[i, j]);
            }
        Console.WriteLine();
    }
}

int [,] array =  FillArray(num);
Console.WriteLine();

PrintArray(array);