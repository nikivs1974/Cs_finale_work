// Program
string[] CreateNewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
        count++;
        }
    }
    string [] result = new string[count];
        int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
        result[temp] = array[i];
        temp++;
        }
    }
    return result;
}

// Print result
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}

// Testing
string [] test1 = new string [] {"1", "777", "123123", "+7(916)999-88-77", "23"};
PrintArray(CreateNewArray(test1));

string [] test2 = new string [] {"Russia", "Denmark", "Kazan"};
PrintArray(CreateNewArray(test2));

string [] test3 = new string [] {"o", "ooooo", "oo", "oooooooo", "ooo"};
PrintArray(CreateNewArray(test3));









