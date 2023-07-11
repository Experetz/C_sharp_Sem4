// Sort array

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

int[] nums = new int[10]; 
FillArray(nums);

 
// сортировка
int temp;
for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] > nums[j])
        {
            temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
 
// вывод
Console.WriteLine("\nSorted array output");
for (int i = 0; i < nums.Length; i++)
{
    Console.Write($"     {nums[i]}");
}