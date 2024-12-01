/*За допомогою enum створити програму, що буде запитувати у користувача кількість днів, 
 * а потім рахувати який буде день через введену кількість, якщо рахувати від понеділка і виводити результат. Наприклад: 
 *   Приклад 1: Вхідний параметр: 13 Очікуваний вивід: Sunday
 *   Приклад 2: Вхідний параметр: 3 Очікуваний вивід: Thursday
 */
Console.Write("Enter amount of days: ");
if (int.TryParse(Console.ReadLine(), out int days))
{
    Console.WriteLine();

    int currentDay = 0; // Monday
    int countDay = (currentDay + days) % 7;
    WeekDays weekDay = (WeekDays)countDay;

    Console.WriteLine($"Day of the week in {days} days: {weekDay}");
}
else
{
    Console.WriteLine("Enter correct even number");
}
enum WeekDays
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}