// Организовать  поиск числа пользователя в массиве.

int RequestNumber(string message)
{
      Console.Write(message);
      string value = Console.ReadLine();  
      int result = Convert.ToInt32(value);
      return result;
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-10, 11);
        Console.Write($"    {collection[index]} ");
        index++;
    }
}
//Линейный поиск
bool Search(int[]array, int number)
{
    for(int i = 0; i < array.Length ; i++)
    {
        if (array[i] == number) return true;
    }
    return false;
}

//Бинарный поиск

/*bool BinarySearch(int[]array, int number)
{
    for(int i = 0; i < array.Length ; i++)
    {
        for(int i = 0; i < array.Length ; i++)
    }
}*/


int SearchingNumber = RequestNumber("Please put a number for search   ");
int[] array = new int[10];
FillArray(array);
bool isNumberFound = Search(array, SearchingNumber);
Console.WriteLine(isNumberFound ? "\n Number found in array!" : "Number not found in array.");
