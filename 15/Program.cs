/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
int GetNumber()
{
    Console.WriteLine("Введите номер дня недели");
    int number = Convert.ToInt32 (Console.ReadLine());
    return number;
}
int number = GetNumber();
if (number > 7)
{
    Console.WriteLine("Такого дня нет");
}
else if (number > 5)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}