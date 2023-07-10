/*Напишите программу, которая принимает на вход число (А) и 
выдаёт сумму чисел от 1 до А.*/

int GetSum (int limit)
{
    int sum = 0;
    for (int i = 1; i <= limit; i++) 
    {
        sum+= i;
    }    
    return sum;
}

//-------------------------------

Console.WriteLine("Please put a number"); 
int usernumber = int.Parse(Console.ReadLine());
GetSum(usernumber);

Console.WriteLine(GetSum(usernumber));