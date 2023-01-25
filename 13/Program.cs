/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6

*/
int GetNumber()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32 (Console.ReadLine());
    return number;
}
int number = GetNumber();
int result = 0;
if (number > 100)
{
    while (number > 1000)
    {
        number = number /10;
    }
    result = number % 10;
 Console.WriteLine (result);   
}
else 
{
    Console.WriteLine ("Третьей цифры нет"); 
}