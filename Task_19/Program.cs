/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да     */

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine()); 
int temporary = num; // Объявляем временную переменную со значением исходного числа
int invertedNum = 0; // Число перевернутое
 
while (temporary != 0)
{
    invertedNum = invertedNum * 10 + temporary % 10; // Переворачиваем число по цифрам
    temporary /= 10; // Отбрасываем последнюю цифру
}
 
if (num == invertedNum)
{
    Console.WriteLine("Число ЯВЛЯЕТСЯ палиндромом");
}
else
{
    Console.WriteLine("Число НЕЯВЛЯЕТСЯ палиндромом");
}