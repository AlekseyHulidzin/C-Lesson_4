// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// ввод элеменетов через консоль (через запятую. использовать метод string.Split())


Console.Write("Введите длинну массива: ");
int lenArray = Convert.ToInt32(Console.ReadLine());


int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1, 99);

    if (i == randomArray.Length - 1)
    {
        Console.Write(randomArray[i]);
    }
    else
    {
        Console.Write(randomArray[i] + ",");
    }
}


// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}