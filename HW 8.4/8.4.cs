/*Створити двовимірний масив 5х5. Заповнити його будь-якими числами. Визначити та вивести на екран: 
 * а) максимальний елемент масиву; б) мінімальний елемент масиву; в) координати мінімального елемента масиву. 
 * г) координати максимального елемента масиву.
 */

Random randomNumber = new Random();

int[,] array2D = new int[5, 5];
int maxElement = int.MinValue;
int minElement = int.MaxValue;
int maxRow = 0, minRow = 0, maxColmn = 0, minColmn = 0;

for  (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        array2D[i, j] = randomNumber.Next(1, 1000);
        if (array2D[i, j] > maxElement)
        { 
            maxElement = array2D[i, j];
            maxRow = i;
            maxColmn = j;
        }
        if (array2D[i, j] < minElement)
        {
            minElement = array2D[i, j];
            minRow = i;
            minColmn = j;
        }
        Console.Write($"{array2D[i, j],4}");
    }
    Console.WriteLine();
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine($"Max element of array: {maxElement}; coordinates: {maxRow}, {maxColmn}");
Console.WriteLine($"Min element of array: {minElement}; coordinates: {minRow}, {minColmn}");