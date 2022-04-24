Console.Write("Print number: ");
string number = Console.ReadLine();
int num = int.Parse(number);

int count = 1;

while(count <= num)
{
    if(count % 2 == 0)
    {
        Console.Write(count);
        Console.Write(", ");
    }
    count++;
}
Console.WriteLine();

// Возможен другие варианты реализации решения данной задачи. например:

//int count = 2;

//while(count < num)
//{
//    Console.Write(count);
//    Console.Write(", ");
//    count = count + 2;
//}
//Console.WriteLine();