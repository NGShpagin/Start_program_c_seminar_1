Console.Write("Print number: ");
string number = Console.ReadLine();
int num = int.Parse(number);

if (num % 2 == 0)
{
    Console.WriteLine("This number is integer");
}

else
{
    Console.WriteLine("This number is odd");
}