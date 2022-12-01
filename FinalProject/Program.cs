// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

string[] CreateArray(int number)
{
    string [] startArray = new string [number];
    for (int i = 0; i<number; i++)
    {
        if (i%10 == 2 && i % 100 != 12)
        {
            Console.Write($"Введите {i+1}-ье слово: "); 
        }
        else
        {
            Console.Write($"Введите {i+1}-ое слово: ");
        }
        startArray[i] = Console.ReadLine();
            
    }
    return startArray;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");

    Console.WriteLine();
}

Console.Write("Введите натуральное число, обозначающее количество слов, которые Вы введёте: ");
int n = Convert.ToInt32(Console.ReadLine());
