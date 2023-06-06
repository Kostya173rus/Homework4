// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InPutNum(string message) // ввод данных
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ShowResult(int a, int b) // возведение в степень
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"Результат: {result}");
}

int num = InPutNum("Введите число, которое нужно возвести в степень: "); // число, которое нужно возвести в степень
int num2 = InPutNum("Введите степень, в которую нужно возвести число: "); // степень, в которую нужно возвести число
ShowResult(num, num2);