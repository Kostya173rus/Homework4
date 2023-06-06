// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int InPutNum(string message) // ввод данных
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int lenghtofarray = InPutNum("Введите длинну массива: ");

int[] array = new int[lenghtofarray]; 
Console.Write("Получился массив: ");
for (int i = 0; i < array.Length; i++)

{
    array[i] = new Random().Next(1, 19);

    Console.Write(array[i] + " ");
}
