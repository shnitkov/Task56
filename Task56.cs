// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] CreateTwoDimensionArray(int firstLength, int secondLenght)
{
    int[,] array = new int[firstLength, secondLenght];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int[,] array = CreateTwoDimensionArray(5, 4);
PrintArray(array);
Console.WriteLine("");

int[,] randomArray = CreateTwoDimensionArray(5, 4);
int SumLine(int[,] randomArray, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

int minSum = 1;
int sum = SumLine(randomArray, 0);
for (int i = 1; i < randomArray.GetLength(0); i++)
    {
        if (sum > SumLine(randomArray, i))
        {
            sum = SumLine(randomArray, i);
            minSum = i + 1;
        }
}
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");
Console.ForegroundColor = ConsoleColor.White;