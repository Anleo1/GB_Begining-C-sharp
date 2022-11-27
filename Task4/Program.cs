Console.Write("Enter first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int thirdNum = Convert.ToInt32(Console.ReadLine());

int maximum = firstNum;
if (maximum < secondNum) {
    maximum = secondNum;
    if (maximum < thirdNum) maximum =thirdNum;
}
else if (maximum < thirdNum) maximum =thirdNum;

Console.WriteLine($"maximum = {maximum}");