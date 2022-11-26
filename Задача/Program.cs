// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 

string[] array1 = new string[7] { "Animals", "dog", "cat", "mouse", "pig", "sheep", "horse" };
string[] arrayNew = new string[array1.Length];

void FillArray(string[] array1, string[] arrayNew)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            arrayNew[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FillArray(array1, arrayNew);
PrintArray(arrayNew);
