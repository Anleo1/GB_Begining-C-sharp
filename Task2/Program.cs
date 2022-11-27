Console.Write("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;
 if(max < secondNumber) max = secondNumber;

Console.WriteLine($"max = {max}");