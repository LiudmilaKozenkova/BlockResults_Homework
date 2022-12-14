// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

// 1. Входные данные
string[] array1 = new string[4] { "hello", "2", "world", "44" };

// 2. Задаем нов массив (его длина = длине массива из входных данных)
string[] array2 = new string[array1.Length];

// 2. Метод заполнения нов массива из строк, длина кот < 3 символов.
void CreateFillNewArray(string[] array1, string[] array2)
{
    int pos = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length < 3)
        {
            array2[pos] = array1[i];
            pos++;
        }
    }
}

// 3. Распечатать массив 
void Print(string[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

CreateFillNewArray(array1, array2);
Print(array2);
