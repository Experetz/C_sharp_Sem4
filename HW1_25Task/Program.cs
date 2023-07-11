/* Напишите программу, которая принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 
*/

int RequestNumber(string message)
{
      Console.Write(message);
      string value = Console.ReadLine();  
      int result = Convert.ToInt32(value);
      return result;
}

double A = RequestNumber("Please put number A  ");
double B = RequestNumber("Please put number B  "); 

if(B <= 0) Console.WriteLine($"Error! number B must be bigger than 0");
else
{
double result = Math.Pow(A, B);
Console.WriteLine($"Your result is {result}");
}