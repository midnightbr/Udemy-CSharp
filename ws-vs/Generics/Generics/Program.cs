using Generics;

PrintService<String> printService = new PrintService<String>();

Console.Write("How many values? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    // int x = int.Parse(Console.ReadLine());
    string x = Console.ReadLine();
    printService.AddValue(x);
}

printService.Print();
Console.WriteLine("First: " + printService.First());