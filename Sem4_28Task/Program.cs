/* Напишите программу, которая принимает на вход число N и 
выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

int GetSum (int limit)
{
    int income = 1;
    for (int i = 1; i <= limit; i++) 
    {
        income*=i;
    }    
    return income;
}

//-------------------------------

Console.WriteLine("Please put a number"); 
int usernumber = int.Parse(Console.ReadLine());
int result = GetSum(usernumber);

Console.WriteLine($"The result is {result}");
