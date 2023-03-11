// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.

string [] ChangeArray (string [] array)
{
    string [] changedArray = new string [array.Length];
    int counter = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            changedArray [counter] = array[i];
            conter++;
        }
    }
    return changedArray;
}

void ShowArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write (array [i] + " ");
    }
    Console.WriteLine();
}