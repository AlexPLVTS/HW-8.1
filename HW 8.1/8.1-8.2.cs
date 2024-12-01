/* Створити масив із 10 елементів типу int. Присвоїти їм випадкові значення від -10 до 10, використовуючи клас Random. 
* Вивести на екран елементи масиву з парним індексом.
* Визначити, чи вірно, що сума елементів масиву є невід'ємне число.
*/

Random randomNumber = new Random();

int[] array = new int[10];

int sumOfElements = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = randomNumber.Next(-10, 10);
    sumOfElements += array[i];

    if (i % 2 == 0)
    {
        Console.WriteLine($"Index {i}: element {array[i]}");
    }
}
if (sumOfElements >= 0)
    {
        Console.WriteLine($"{sumOfElements} - sum of elements is positive");
    }
else
    {
        Console.WriteLine($"{sumOfElements} - sum of elements is negative");
    }

