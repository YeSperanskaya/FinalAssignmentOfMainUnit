void PrintArray(string [] arr)
{
    Console.Write('[');
    for (int index = 0; index < arr.Length; index++)
    {
        if (index < arr.Length-1)
        {
            Console.Write($"{arr[index]}, ");
        }
        else
        {
            Console.Write($"{arr[index]}");
        }            
    }
    Console.WriteLine(']');
}

string [] arrayStart = {"Hello", "2", "world", ":-)"};
List <string> listResult = new List<string>();
int maxSizeWord = 3;
for (int i = 0; i < arrayStart.Length; i++)
    {
        if (arrayStart[i].Length <= maxSizeWord)
        {
            listResult.Add(arrayStart[i]);
        }
    }
string [] arrayResult = listResult.ToArray();
PrintArray(arrayStart);
PrintArray(arrayResult);






