/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int GetNumber()
{
    Console.WriteLine("Введите трехзначное число");
    int number = Convert.ToInt32 (Console.ReadLine());
    return number;
}
int number = GetNumber();
int result = 0;
result = (number / 10) % 10;
Console.WriteLine(result);
