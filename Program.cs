string[] ASmallArray(string[] incomeArray, int textLength)
{
    string[] newArray = new string[0];     // новый пустой массив
    int j = 0;
    int lengthArray = incomeArray.Length;   // длина массива
    for (int i = 0; i < lengthArray; i++)  // проверка на длину массива пока выполняется условие i < lengthArray
    {
        if (incomeArray[i].Length <= textLength)
        {
            Array.Resize(ref newArray, j + 1);    // Увеличим размер нового массива
            newArray[j] = incomeArray[i];
            j++;
        }
    }
    return newArray;
}

Console.WriteLine("Введите все слова в одну строку через пробел: ");
// Считаем строку, разделим ее на слова, и внесем в массив)
string[] array = Console.ReadLine().Split(' ').ToArray();

Console.WriteLine($"\nЗаданный массив: [{String.Join("; ", array)}]");
Console.WriteLine($"Новый массив:    [{String.Join("; ", ASmallArray(array, 3))}]");
