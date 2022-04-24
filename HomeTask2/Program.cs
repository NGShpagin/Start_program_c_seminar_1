Console.Write("Print 1st number: ");
string number1 = Console.ReadLine();
int num1 = int.Parse(number1);


Console.Write("Print 2nd number: ");
string number2 = Console.ReadLine();
int num2 = int.Parse(number2);


Console.Write("Print 3rd number: ");
string number3 = Console.ReadLine();
int num3 = int.Parse(number3);

int max = num1;
int min = num2;

if(num2 > max) max = num2;
if(num3 > max) max = num3;
if(num1 < min) min = num1;
if(num3 < min) min = num3;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);