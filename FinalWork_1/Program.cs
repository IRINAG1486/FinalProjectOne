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
            counter++;
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

string [] givenArray = {"Hello", "000", "11", "2", "Goodbye", "Bye", "Hi", "Yes", "No"};
ShowArray (givenArray);
string [] newArray = ChangeArray (givenArray);
ShowArray (newArray);