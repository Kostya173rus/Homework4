//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InPutNum(string message) // ввод данных
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int FindLenght(int a) // найдем длину числа
{
    int longofnum = 0;
    while (a > 0)
    {
        a /= 10;
        longofnum++;
    }
    return longofnum;
}
void ShowResult (int b, int lenght) // сумма цифр в числе
{
    int result = 0;
    for (int i = 1; i <= lenght; i++)
    {
        result += b % 10;
        b /= 10;
    }
    Console.WriteLine($"Сумма всех чисел, введенного числа: {result}");
}
int num = InPutNum("Введите число: ");
int lenght = FindLenght(num);
ShowResult(num, lenght);