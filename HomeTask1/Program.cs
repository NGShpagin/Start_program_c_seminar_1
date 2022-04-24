Console.Write("Print 1st number: ");
string number1 = Console.ReadLine();
int num1 = int.Parse(number1);


Console.Write("Print 2nd number: ");
string number2 = Console.ReadLine();
int num2 = int.Parse(number2);

int max = num1;
int min = num2;

if(num2 > num1) 
{
    max = num2; 
    min = num1;
}

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);