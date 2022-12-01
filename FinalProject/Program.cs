// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

string[] CreateArray(int number)
{
    string [] startArray = new string [number];
    for (int i = 0; i<number; i++)
    {
        if (i%10 == 2 && i % 100 != 12)
            Console.Write($"Введите {i+1}-ье слово: "); 
        else Console.Write($"Введите {i+1}-ое слово: ");
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

string[] CheckFor3Symb(string[] array)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++)
        if (array[i].Length <= 3) count++;
    if (count == 0)
        return array;
    else
    {
        string [] newArray = new string [count];
        int count2 = 0;
        for (int j=0; j<array.Length; j++)
        {
            if(array[j].Length <= 3)
            {
                newArray[count2] = array[j];
                count2++;
            }
        }
        return newArray; 
    }  
}

Console.Write("Введите натуральное число, обозначающее количество слов, которые Вы введёте: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(n);
// ShowArray(myArray);
CheckFor3Symb(myArray);